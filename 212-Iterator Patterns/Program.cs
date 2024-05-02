using System.Collections;

Vector3 position = new Vector3(12, 3, -4);

foreach (var value in position)
{
    Console.WriteLine(value);
}

struct Vector3 : IEnumerable<float>
{
    public float x, y, z;

    public Vector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public IEnumerator<float> GetEnumerator()
    {
        return new VectorEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public class VectorEnumerator : IEnumerator<float>
    {
        private Vector3 vector;
        private int index;

        public VectorEnumerator(Vector3 vector)
        {
            this.vector = vector;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return index < 4;
        }

        public void Reset()
        {
            index = 0;
        }

        public float Current
        {
            get
            {
                switch (index)
                {
                    case 1: return vector.x;
                    case 2: return vector.y;
                    case 3: return vector.z;
                    default: throw new Exception();
                }
            }
        }

        object IEnumerator.Current => Current;
    }
}