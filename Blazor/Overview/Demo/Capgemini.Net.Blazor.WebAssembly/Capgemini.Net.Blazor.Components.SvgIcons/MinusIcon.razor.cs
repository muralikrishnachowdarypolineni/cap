﻿using Capgemini.Net.Blazor.Components.SvgIcons.Base;

namespace Capgemini.Net.Blazor.Components.SvgIcons
{
    public partial class MinusIcon : IconBase
    {
        protected override void OnParametersSet()
        {
            Height ??= "36px";
            Width ??= "36px";
            base.OnParametersSet();
        }
    }
}