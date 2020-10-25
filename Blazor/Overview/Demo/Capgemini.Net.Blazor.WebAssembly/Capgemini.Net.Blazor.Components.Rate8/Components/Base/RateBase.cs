﻿using Microsoft.AspNetCore.Components;

namespace Capgemini.Net.Blazor.Components.Rate9.Base
{
    public class RateBase : ComponentBase
    {
        public static string ACTIVE_STYLE = "fas";

        public static string INACTIVE_STYLE = "far";

        private int rate;

        protected int Rate
        {
            get => rate;
            set
            {
                rate = value;
                tempRate = rate;
            }
        }

        protected int tempRate = 0;

        protected bool IsActive(int index) => index <= tempRate;

        protected void SetRate() => rate = tempRate;

        protected void ShowRate(int index) => tempRate = index;

        protected void RevertRate() => tempRate = rate;
    }
}
