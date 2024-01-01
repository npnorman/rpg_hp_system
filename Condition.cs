using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hp_system {
    public class Condition {
        //to customize this class, make a child of it!

        int hpModifier;

        public Condition() { 
            hpModifier = 1;
        }

        public Condition(int hpModifier) {
            this.hpModifier = hpModifier;
        }

        public int getHpModifier() {
            return hpModifier;
        }

        public void setHpModifier(int hpModifier) {
            this.hpModifier = hpModifier;
        }

        public virtual int HPFormula() {
            //this returns the amount of hp lost or gained by the player
            //this is meant to be replaced in a child function
            return hpModifier * -1;
        }

        public virtual bool isValid() {
            //this is meant to be replaced in a child function
            //this returns false if condition should be removed from the player
            return true; //this condition will never be removed unless manually by the user
        }

        public override string ToString() {
            return HPFormula().ToString();
        }
    }
}
