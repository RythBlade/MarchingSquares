using System;
using System.Collections.Generic;
using System.Text;

namespace MarchingSquares
{
    public class MSParticleField
    {
        private List<MSParticle> pointList = null;

        public List<MSParticle> ParticleList
        {
            get { return pointList; }
        }

        public MSParticleField()
        {
            pointList = new List<MSParticle>();
        }

        public MSParticleField(int intialCapacity)
        {
            pointList = new List<MSParticle>(intialCapacity);
        }

        public void AddParticle(float x, float y, float radius)
        {
            pointList.Add(new MSParticle(new MSPoint(x, y), radius));
        }

        public float DensityAtLocation(MSPoint point)
        {
            float density = 0.0f;

            foreach( MSParticle particle in ParticleList)
            {
                float distanceToParticleSqr = (particle.Position - point).LengthSqr();
                
                if(distanceToParticleSqr <= particle.RadiusSqr )
                {
                    density += 1.0f;
                }
            }

            return density;
        }
    }
}
