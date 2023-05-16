namespace Pets {
    public class PetsCounter {
        private int _cat = 0;
        private int _dog = 0;
        private int _capybara = 0;

        public int Incrementcat() {
            _cat++;
            return _cat;
        }
        public int Incrementdog() {
            _dog++;
            return _dog;
        }
        public int Incrementcapybara() {
            _capybara++;
            return _capybara;
        }

        public int cat {
            get { return _cat; }
        }
        public int dog {
            get { return _dog; }
        }
        public int capybara {
            get { return _capybara; }
        }
    }
}
