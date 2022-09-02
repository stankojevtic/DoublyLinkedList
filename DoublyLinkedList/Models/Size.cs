using System;
namespace DoublyLinkedList.App.Models
{
    public class Size : System.IComparable<Size>
    {
        int value;

        public Size(int i)
        {
            value = i;
        }

        public int CompareTo(Size size)
        {
            return value - size.value;
        }

        public bool Equals(Size size)
        {
            return (this.value == size.value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}

