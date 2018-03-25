using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using HelperClasses;

namespace MenuFramework
{
    public class Main : BaseScript
    {
        private static Main instance;
        public static Main Instance => instance ?? (instance = new Main());
        public event Func<Task> TickEvent
        {
            add => Tick += value;
            remove => Tick -= value;
        }

        public Main()
        {
            InteractionListMenu.Init();
            DevVehicleMenu.Init();
            DevCharacterMenu.Init();
        }
    }
}
