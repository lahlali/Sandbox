﻿using System;
using System.Threading;
using Framework;

namespace CalculatorActor
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                ServiceFabricFramework
                    .CreateActorContainerBuilder<CalculatorActor>()
                    .Register();

                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ActorEventSource.Current.ActorHostInitializationFailed(e.ToString());
                throw;
            }
        }
    }
}
