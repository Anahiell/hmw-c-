using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Out
{
    public class MyArray:ICalc,IOutput2,ICalc2
    {
        private int[] _array;
        private int _size;
        private int Count;
        private string Arr;
        private void CreateArray()
        {
            Random RND = new Random();
            _array = new int[_size];
            for (int i = 0; i < _size; i++)
            {
                _array[i] = RND.Next(1,100);
            }
        }
        public int Size
        {
            get { return _size; }
            set
            {
                if (_size > 0 && value != _size)
                {
                    _size = value;
                    CreateArray();
                }
            }
        }

        public MyArray(int size)
        {
            if (size > 0)
            {
                _size = size;
                CreateArray();
            }

        }
        public MyArray()
        {
            _size = 10;
            CreateArray();
        }

        public int this[int index] //индексатор - отдельная конструкция языка
        {
            get
            {
                if (index >= 0 && index < _size)
                {
                    return _array[index];
                }
                throw new Exception("Error index");
            }
            set
            {
                if (index >= 0 && index < _size)
                {
                    _array[index] = value;
                }
            }
        }
        public int Less(int valToComp)//маленькие
        {
            Count = 0;
            for(int i=0;i<_size;i++)
            {
                if (_array[i] < valToComp)
                    Count++;
            }
            return Count;
        }
        public int Greater(int valToComp)//большие числа
        {
            Count = 0;
            for (int i = 0; i < _size; i++)
            {
                if (_array[i] > valToComp)
                    Count++;
            }
            return Count;
        }
        public void ShowEven()//показывает парные числа в массиве
        {
            for (int i = 0; i < _size; i++)
            {
              if(_array[i]%2==0)
              {
                    Console.Write(_array[i] + "; ");
              }
            }
        }  
        public void ShowOdd()//покаазывает не парные числа в массиве
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i] % 2 != 0)
                {
                    Console.Write(_array[i] + "; ");
                }
            }
        }
       public int CountDistinct()//кол-во уникальных значений в массиве
        {
            Count = 0;
            for (int i = 0; i < _size-1; i++)
            {
                for (int j = i+1; j < _size; j++)
                {
                    if (_array[i] == _array[j])
                    {
                        break;
                    }
                    if (j == _size - 1)
                        Count++;
                }
            }
            return Count;
        }
       public int EqualToValue(int valueToComp)//кол-во значений равному valueToComp
        {
            Count = 0;
            for (int i = 0; i < _size; i++)
            {
                if (_array[i]== valueToComp)
                {
                    Count++;
                }
            }
            return Count;
        }
        public override string ToString()
        {
            for(int i=0;i<_size;i++)
            {
                Arr += _array[i];
                Arr += "|";
            }
           
            return Arr;
        }
    }
}
