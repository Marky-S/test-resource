using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

#pragma warning disable CS1998

namespace Client
{
    partial class Class2 : BaseScript
    {
        private async Task Tick1Task()
        {
            await Delay(1);
        }

        [Tick]
        private async Task Tick1()
        {
            await Delay(1);

            int value = 5;

            value *= value * value * value;

            await Tick1Task();
        }

        private async Task Tick2Task()
        {
            await Delay(1);
        }

        [Tick]
        private async Task Tick2()
        {
            await Delay(1);

            int value = 5;

            value *= value * value * value;

            await Tick2Task();
        }

        private async Task Tick3Task()
        {
            await Delay(1);
        }

        [Tick]
        private async Task Tick3()
        {

            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick3Task();
        }

        private async Task Tick4Task()
        {
            await Delay(1);
        }

        [Tick]
        private async Task Tick4()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick94()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick84()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick74()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick64()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick54()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick44()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick34()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }


        [Tick]
        private async Task Tick14()
        {
            int value = 5;

            value *= value * value * value;

            await Delay(1);

            await Tick4Task();
        }

    }
}
