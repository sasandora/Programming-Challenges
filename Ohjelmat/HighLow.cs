using System;

namespace Programming_Challenges {
    class HighLow {
        private int _voittoPutki, _arpa1, _arpa2;
        private bool _voitto;
        Random rand = new Random();

        public HighLow() {
            _voittoPutki = 0;
            _voitto = false;
        }

        public int ArvoYksi() {
            _arpa1 = rand.Next(0, 99);
            return _arpa1;
        }

        public bool Veikkaus(bool _isompi) {

            _voitto = TarkistaTulos(ArvoToinen(), _isompi);
            if(_voitto == true)
                _voittoPutki++;
            else
                _voittoPutki = 0;
            return _voitto;

            int ArvoToinen() {
                _arpa2 = rand.Next(0, 99);
                return _arpa2;
            }
            bool TarkistaTulos(int _a2, bool _veikkaus) {

                if(_veikkaus == true && _arpa1 < _arpa2) {
                    //VOITIT
                    return true;
                } else if(_veikkaus == false && _arpa1 < _arpa2) {
                    //HÄVISIT
                    return false;
                } else if(_veikkaus == false && _arpa1 > _arpa2) {
                    // VOITIT
                    return true;
                } else if(_veikkaus == true && _arpa1 > _arpa2) {
                    // HÄVISIT
                    return false;
                }
                return true;
            }
        }



        public int Voittoputki {
            get => _voittoPutki;
        }
        public int Arpa1 {
            get => _arpa1;
        }
        public int Arpa2 {
            get => _arpa2;
        }
        public bool Voitto {
            get => _voitto;
        }
    }
}
