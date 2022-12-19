using BenchmarkDotNet.Attributes;

namespace Sealed.Classes
{
    [MemoryDiagnoser(false)]
    public class Benchmarking
    {
        private readonly int NumberOfTrials = 10;
        private BaseClass _baseClassObject = new BaseClass();
        private MyClass _myClassObject = new MyClass();
        private MySealedClass _mySealedClassObject = new MySealedClass();
        private MyClass[] _myClassObjectsArray = new MyClass[1];
        private MySealedClass[] _mySealedClassObjectsArray = new MySealedClass[1];

        [Benchmark]
        public void CallingNonVirtualMethodOnMyClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                _myClassObject.DoSomethingElse();
            }
        }

        [Benchmark]
        public void CallingNonVirtualMethodOnMySealedClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                _mySealedClassObject.DoSomethingElse();
            }
        }

        [Benchmark]
        public void CallingVirtualMethodOnMyClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                _myClassObject.DoSomething();
            }
        }

        [Benchmark]
        public void CallingVirtualMethodOnMySealedClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                _mySealedClassObject.DoSomething();
            }
        }

        [Benchmark]
        public bool ObjectTypeIsMyClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                var x = _baseClassObject is MyClass;
            }

            return true;
        }

        [Benchmark]
        public bool ObjectTypeIsMySealedClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                var x= _baseClassObject is MySealedClass;
            }

            return true;
        }

        [Benchmark]
        public void ObjectTypeAsMyClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                var x = _baseClassObject as MyClass;
            }
        }

        [Benchmark]
        public void ObjectTypeAsMySealedClass()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                var x = _baseClassObject as MySealedClass;
            }
        }

        [Benchmark]
        public void StoringValuesInMyClassArray()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                _myClassObjectsArray[0] = _myClassObject;
            }
        }

        [Benchmark]
        public void StoringValuesInMySealedClassArray()
        {
            for (var i = 0; i < NumberOfTrials; i++)
            {
                _mySealedClassObjectsArray[0] = _mySealedClassObject;
            }
        }
    }
}
