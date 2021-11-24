using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseGestureRecognition.Common
{
    public static class CharExtensions
    {
        public static void IsEnter(this char character, Action onEnterPressed)
        {
            if (character == (char)13)
                onEnterPressed();
        }
    }
}
