﻿using System;

namespace Mediator.Net
{
    public interface IResolver
    {
        T Resolve<T>(Type t);
        object Resolve(Type t);
        IDependancyScope BeginScope();
    }
}