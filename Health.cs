using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hp_system
{
    public class Health
    {
        int hp; //health points
        ArrayList conditions = new ArrayList();

        public Health() {
            hp = 0;
        }

        public Health(int hp) {
            this.hp = hp;
        }

        public void SetHp(int hp) {
            this.hp = hp;
        }

        public int GetHp() {
            return hp;
        }

        public ArrayList getConditions() {
            //will return condtions
            return conditions;
        }

        public void AddCondition(Condition condition) {
            conditions[0] = condition;
        }

        public void addHP(int hp) {
            this.hp += hp;
        }
    }
}
