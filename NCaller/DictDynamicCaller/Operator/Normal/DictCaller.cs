﻿using NCaller.Builder;
using System;
namespace NCaller
{
    public class DictCaller
    {
        public static CallerBase Create(Type type)
        {
           return DictCallerBuilder.Ctor(type);
        }
    }
    public class DictCaller<T>
    {
        public static CallerBase Create()
        {
            return DictCallerBuilder<T>.Ctor();
        }
    }
}