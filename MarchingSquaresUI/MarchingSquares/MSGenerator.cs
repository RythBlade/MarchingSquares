using System.Collections.Generic;

namespace MarchingSquares
{
    public enum SquareSide
    {
        eNone = 0
        , eTop = 1 << 0
        , eLeft = 1 << 1
        , eRight = 1 << 2
        , eBottom = 1 << 3
    }

    public class MSGenerator
    {
        private List<MSLine> generatedLines = new List<MSLine>(100);

        public List<MSLine> GeneratedLines
        {
            get { return generatedLines; }
        }

        private int cellSize = 20;
        float[,] densityArray = null;
        MSPoint min = new MSPoint(0.0f);
        MSPoint max = new MSPoint(0.0f);

        public float[,] DensityArray
        {
            get { return densityArray; }
        }

        public float DensityThreshold
        {
            get; set;
        }

        public MSPoint MinExtent
        {
            get { return min; }
        }

        public MSPoint MaxExtent
        {
            get { return max; }
        }

        public int CellSize
        {
            get { return cellSize; }
            set
            {
                cellSize = value;

                if (cellSize < 1)
                {
                    cellSize = 1;
                }

                if (cellSize > 100)
                {
                    cellSize = 100;
                }
            }
        }

        private List<SquareSide>[] edgeTable = new List<SquareSide>[16];

        public MSGenerator()
        {
            DensityThreshold = 0.5f;

            for (int i = 0; i < 16; ++i)
            {
                edgeTable[i] = new List<SquareSide>(2);
            }

            //////////////////////////////////////////////////////////////////
            //             Top
            //      A----------------B
            //      |                |
            //      |                |
            //      |                |
            // Left |                | Right
            //      |                |
            //      |                |
            //      |                |
            //      C----------------D
            //            Bottom
            //
            // A == 1000 == 8
            // B == 0100 == 4
            // C == 0001 == 1
            // D == 0010 == 2
            //
            //////////////////////////////////////////////////////////////////

            edgeTable[0].Add(SquareSide.eNone);
            edgeTable[1].Add(SquareSide.eLeft | SquareSide.eBottom);
            edgeTable[2].Add(SquareSide.eRight | SquareSide.eBottom);
            edgeTable[3].Add(SquareSide.eLeft | SquareSide.eRight);
            edgeTable[4].Add(SquareSide.eTop | SquareSide.eRight);

            edgeTable[5].Add(SquareSide.eLeft | SquareSide.eTop);
            edgeTable[5].Add(SquareSide.eBottom | SquareSide.eRight);

            edgeTable[6].Add(SquareSide.eTop | SquareSide.eBottom);
            edgeTable[7].Add(SquareSide.eLeft | SquareSide.eTop);
            edgeTable[8].Add(SquareSide.eTop | SquareSide.eLeft);
            edgeTable[9].Add(SquareSide.eTop | SquareSide.eBottom);

            edgeTable[10].Add(SquareSide.eTop | SquareSide.eRight);
            edgeTable[10].Add(SquareSide.eLeft | SquareSide.eBottom);

            edgeTable[11].Add(SquareSide.eTop | SquareSide.eRight);
            edgeTable[12].Add(SquareSide.eLeft | SquareSide.eRight);
            edgeTable[13].Add(SquareSide.eBottom | SquareSide.eRight);
            edgeTable[14].Add(SquareSide.eLeft | SquareSide.eBottom);
            edgeTable[15].Add(SquareSide.eNone);
        }

        public void ResetData()
        {
            generatedLines.Clear();
            densityArray = null;
        }

        public void GenerateLines(MSParticleField particleField)
        {
            ResetData();

            if (particleField.ParticleList.Count <= 0)
            {
                return;
            }

            min = new MSPoint(float.MaxValue);
            max = new MSPoint(float.MinValue);

            MSPoint particleRadius = new MSPoint(0.0f);

            // find the extents of the area we need to surround with lines (include the particle radius)
            foreach (MSParticle particle in particleField.ParticleList)
            {
                particleRadius.X = particle.Radius;
                particleRadius.Y = particle.Radius;

                min = MSPoint.min(particle.Position - particleRadius, min);
                max = MSPoint.max(particle.Position + particleRadius, max);
            }

            // round up/down to the nearest cell size, then expand out another cell - incase the min/max is already aligned to the grid
            min.X = min.X - (min.X % cellSize) - cellSize;
            min.Y = min.Y - (min.Y % cellSize) - cellSize;

            max.X = max.X + (cellSize - (max.X % cellSize)) + cellSize;
            max.Y = max.Y + (cellSize - (max.Y % cellSize)) + cellSize;

            int xSteps = (int)((max.X - min.X) / cellSize);
            int ySteps = (int)((max.Y - min.Y) / cellSize);

            // sample the field density at each square's corner
            densityArray = new float[xSteps, ySteps];
            MSPoint testPoint = new MSPoint(0.0f);

            for (int x = 0; x < xSteps; ++x)
            {
                for (int y = 0; y < ySteps; ++y)
                {
                    testPoint.X = min.X + (float)x * cellSize;
                    testPoint.Y = min.Y + (float)y * cellSize;

                    densityArray[x, y] = particleField.DensityAtLocation(testPoint);
                }
            }

            // for each square - look up in the connections table what lines to generate and add them
            for (int x = 0; x < xSteps - 1; ++x)
            {
                for (int y = 0; y < ySteps - 1; ++y)
                {
                    float upperLeft = densityArray[x, y];
                    float upperRight = densityArray[x + 1, y];
                    float lowerLeft = densityArray[x, y + 1];
                    float lowerRight = densityArray[x + 1, y + 1];

                    int tableIndex = 0;

                    tableIndex |= upperLeft >= DensityThreshold ? 8 : 0;
                    tableIndex |= upperRight >= DensityThreshold ? 4 : 0;
                    tableIndex |= lowerLeft >= DensityThreshold ? 1 : 0;
                    tableIndex |= lowerRight >= DensityThreshold ? 2 : 0;

                    List<SquareSide> edges = edgeTable[tableIndex];

                    foreach (SquareSide edge in edges)
                    {
                        int index = 0;
                        MSPoint[] line = new MSPoint[2];

                        if ((edge & SquareSide.eTop) > 0)
                        {
                            float interpolationFactor = (DensityThreshold - upperLeft) / (upperRight - upperLeft);

                            line[index] = new MSPoint(
                                min.X + (float)x * cellSize + cellSize * interpolationFactor
                                , min.Y + (float)y * cellSize);
                            ++index;
                        }

                        if ((edge & SquareSide.eBottom) > 0)
                        {
                            float interpolationFactor = (DensityThreshold - lowerLeft) / (lowerRight - lowerLeft);

                            line[index] = new MSPoint(
                                min.X + (float)x * cellSize + cellSize * interpolationFactor
                                , min.Y + (float)(y + 1) * cellSize);
                            ++index;
                        }

                        if ((edge & SquareSide.eLeft) > 0)
                        {
                            float interpolationFactor = (DensityThreshold - upperLeft) / (lowerLeft - upperLeft);

                            line[index] = new MSPoint(
                                min.X + (float)x * cellSize
                                , min.Y + (float)y * cellSize + cellSize * interpolationFactor);
                            ++index;
                        }

                        if ((edge & SquareSide.eRight) > 0)
                        {
                            float interpolationFactor = (DensityThreshold - upperRight) / (lowerRight - upperRight);

                            line[index] = new MSPoint(
                                min.X + (float)(x + 1) * cellSize
                                , min.Y + (float)y * cellSize + cellSize * interpolationFactor);
                            ++index;
                        }

                        if (index == 2)
                        {
                            generatedLines.Add(new MSLine(line[0], line[1]));
                        }
                    }
                }
            }
        }
    }
}
