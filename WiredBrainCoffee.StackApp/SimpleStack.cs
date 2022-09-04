﻿namespace WiredBrainCoffee.StackApp
{
    public class SimpleStackDouble
    {
        private readonly double[] _item;
        private int _currentIndex = -1;

        public SimpleStackDouble() => _item = new double[10];
        public int Count => _currentIndex + 1;
        public void Push(double item) => _item[++_currentIndex] = item;
        public double Pop() => _item[_currentIndex--];
    }

    public class SimpleStackString
    {
        private readonly string[] _item;
        private int _currentIndex = -1;

        public SimpleStackString() => _item = new string[10];
        public int Count => _currentIndex + 1;
        public void Push(string item) => _item[++_currentIndex] = item;
        public string Pop() => _item[_currentIndex--];
    }
}