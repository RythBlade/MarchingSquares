namespace MarchingSquares
{
    public class MSParticle
    {
        private MSPoint position = new MSPoint(0.0f);

        // we'll need this a lot, so cache it whenever the radius changes
        private float radiusSqr = 0.0f;
        private float radius = 0.0f;

        public MSPoint Position
        {
            get { return position; }
            set
            {
                if(value != null)
                {
                    position = value;
                }
                else
                {
                    position = new MSPoint(0.0f);
                }
            }
        }
        public float Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                radiusSqr = radius * radius;
            }
        }

        public float RadiusSqr
        {
            get { return radiusSqr; }
        }

        public MSParticle(MSPoint point, float _radius)
        {
            Position = point;
            Radius = _radius;
        }

        public MSParticle()
        {
            Position = null;
            Radius = 0.0f;
        }
    }
}
