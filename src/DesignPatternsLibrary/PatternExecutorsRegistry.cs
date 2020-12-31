﻿using DesignPatternsLibrary.PatternExecutors;
using Greeter;
using System.Collections.Generic;

namespace DesignPatternsLibrary
{
    public class PatternExecutorsRegistry
    {
        private static PatternExecutorsRegistry _instance = null;

        private readonly SortedDictionary<int, PatternExecutor> _executors;

        private PatternExecutorsRegistry()
        {
            _executors = new SortedDictionary<int, PatternExecutor>
            {
                { 1, new SingletonGreeterExecutor() }
            };
        }

        public static PatternExecutorsRegistry Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PatternExecutorsRegistry();
                }

                return _instance;
            }
        }

        public SortedDictionary<int, PatternExecutor> GetAll()
        {
            return _executors;
        }
    }
}
