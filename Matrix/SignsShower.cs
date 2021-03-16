using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class SignsShower
    {
        private int _heightWindow;
        private int _widthWindow;
        private int[] _widthPosSimple;
        private int[] _widthPosAddition;

        private readonly Sign _sign = new Sign();

        public SignsShower() : this((Console.WindowWidth - 1), Console.WindowHeight)
        { }
        public SignsShower(int windowWidth, int windowHeight)
        {
            Initialization(windowWidth, windowHeight);
        }

        private void Initialization(int windowWidth, int windowHeight)
        {
            _heightWindow = windowHeight;

            int h1 = _heightWindow / 2; 
            int h2 = _heightWindow / 4; 

            _widthWindow = windowWidth;

            _widthPosSimple = new int[_widthWindow];
            _widthPosAddition = new int[_widthWindow];

            for (int i = 0; i < _widthWindow; i++)
            {
                _widthPosSimple[i] = Sign.RandomGen.Next(_heightWindow);

                int k = (i % 11 != 10) ? 2 : 1;
                int min = h2 * k;
                int max = h1 * k;
                _widthPosAddition[i] = Sign.RandomGen.Next(min, max);
            }
        }

        public void SignShow()
        {
            for (int i = 0; i < _widthWindow; i++)
            {
                if (_widthPosSimple[i] < 10)
                {
                    _sign.ShowDarkGreenSign(i, _widthPosSimple[i]);
                }
                else if (_widthPosSimple[i] < 25)
                {
                    _sign.ShowGreenSign(i, _widthPosSimple[i]);
                }
                else
                {
                    _sign.ShowWhiteSign(i, _widthPosSimple[i]);
                }

                _widthPosSimple[i] = CheckNextHeightPosition(_widthPosSimple[i] + 1, _heightWindow);

                int next = _widthPosSimple[i] - _widthPosAddition[i];
                int nextPos = CheckNextHeightPosition(next, _heightWindow);
                _sign.ShowSpaceSign(i, nextPos);
            }
        }


        private int CheckNextHeightPosition(int next, int height)
        {
            next = next % height;

            if (next < 0)
            {
                return next + height;
            }
            else
            {
                return next;
            }

        }
    }
}
