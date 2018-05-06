using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public enum Lgota { neLgotnik, veteranTruda, veteranVoiny }
    public class Humans
    {
        public Humans(int _tarifNaOtoplenie = 20, int _tarifNaVodu = 16, int _tarifNaGaz = 15, int _tarifNaRemont = 25)
        {
            lgota = Lgota.neLgotnik;
            tarifNaGaz = _tarifNaGaz;
            tarifNaOtoplenie = _tarifNaOtoplenie;
            tarifNaVodu = _tarifNaVodu;
            tarifNaRemont = _tarifNaRemont;
        }
        public Humans(Lgota l, int _tarifNaOtoplenie = 20, int _tarifNaVodu = 16, int _tarifNaGaz = 15, int _tarifNaRemont = 25)
        {
            lgota = l;
            tarifNaGaz = _tarifNaGaz;
            tarifNaOtoplenie = _tarifNaOtoplenie;
            tarifNaVodu = _tarifNaVodu;
            tarifNaRemont = _tarifNaRemont;

        }
        public Lgota lgota { get; set; }

        private int tarifNaOtoplenie_;
        public int tarifNaOtoplenie
        {
            get
            {
                return tarifNaOtoplenie_;
            }
            set
            {
                tarifNaOtoplenie_ = value;

                if (lgota == Lgota.veteranTruda)
                {
                    tarifNaOtoplenie_ = (value / 10) * 7;
                }
                else if (lgota == Lgota.veteranVoiny)
                {
                    tarifNaOtoplenie_ = (value / 10) * 5;
                }
                else
                {
                    tarifNaOtoplenie_ = value;
                }
            }
        }
        private int tarifNaVodu_;
        public int tarifNaVodu
        {
            get
            {
                return tarifNaVodu_;
            }
            set
            {
                tarifNaVodu_ = value;
                if (lgota == Lgota.veteranTruda)
                {
                    tarifNaVodu_ = (value / 10) * 7;
                }
                else if (lgota == Lgota.veteranVoiny)
                {
                    tarifNaVodu_ = (value / 10) * 5;
                }
                else
                {
                    tarifNaVodu_ = value;
                }
            }
        }
        private int tarifNaGaz_;
        public int tarifNaGaz
        {
            get
            {
                return tarifNaGaz_;
            }
            set
            {
                tarifNaGaz_ = value;
                if (lgota == Lgota.veteranTruda)
                {
                    tarifNaGaz_ = (value / 10) * 7;
                }
                else if (lgota == Lgota.veteranVoiny)
                {
                    tarifNaGaz_ = (value / 10) * 5;
                }
                else
                {
                    tarifNaGaz_ = value;
                }
            }
        }
        private int tarifNaRemont_;
        public int tarifNaRemont
        {
            get
            {
                return tarifNaRemont_;
            }
            set
            {
                tarifNaRemont_ = value;
                if (lgota == Lgota.veteranTruda)
                {
                    tarifNaRemont_ = (value / 10) * 7;
                }
                else if (lgota == Lgota.veteranVoiny)
                {
                    tarifNaRemont_ = (value / 10) * 5;
                }
                else
                {
                    tarifNaRemont_ = value;
                }
            }
        }

    }
}
