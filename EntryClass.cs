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
    partial class EntryClass : BaseScript
    {
        private bool ticksEnabled;
        private List<TestDataClass> testDataClasses = new List<TestDataClass>();

        public EntryClass()
        {
            RegisterCommand("ticks", new Action(this.SwitchTicksStates), false);
            RegisterCommand("data", new Action(this.SwitchDataStates), false);

            Spawn();
        }

        private async void Spawn()
        {
            await Game.Player.ChangeModel(new Model("mp_m_freemode_01"));

            SetPedDefaultComponentVariation(Game.PlayerPed.Handle);

            Game.PlayerPed.Position = new Vector3(0f, 0f, 70f);

            ShutdownLoadingScreenNui();
            ShutdownLoadingScreen();

            DoScreenFadeIn(500);
        }

        private void SwitchDataStates()
        {
            bool anyData = this.testDataClasses.Count > 0;

            if (anyData)
            {
                this.testDataClasses = new List<TestDataClass>();

                GC.Collect();
            }
            else
            {
                for (int i = 0; i < 1000000; i++)
                {
                    this.testDataClasses.Add(new TestDataClass());
                }
            }

            Debug.WriteLine($"Data {(anyData ? "cleared" : "filled")}");
        }

        private void SwitchTicksStates()
        {
            if (this.ticksEnabled)
            {
                Tick -= this.OnFirstTick;
                Tick -= this.OnSecondTick;
                Tick -= this.OnThirdTick;
                Tick -= this.OnFourthTick;
            }
            else
            {
                Tick += this.OnFirstTick;
                Tick += this.OnSecondTick;
                Tick += this.OnThirdTick;
                Tick += this.OnFourthTick;
            }

            this.ticksEnabled = !this.ticksEnabled;

            Debug.WriteLine($"Ticks {(this.ticksEnabled ? "enabled" : "disabled")}");
        }

        #region Ticks
        private async Task OnFirstTick()
        {
            if(IsControlJustPressed(0, 0))
            {
                Debug.WriteLine("Control [V] pressed.");
            }
        }

        private async Task OnSecondTick()
        {
            if (IsControlJustPressed(0, 0))
            {
                Debug.WriteLine("Control [V] pressed.");
            }
        }

        private async Task OnThirdTick()
        {
            if (IsControlJustPressed(0, 0))
            {
                Debug.WriteLine("Control [V] pressed.");
            }
        }

        private async Task OnFourthTick()
        {
            if (IsControlJustPressed(0, 0))
            {
                Debug.WriteLine("Control [V] pressed.");
            }
        }
        #endregion
    }
}
