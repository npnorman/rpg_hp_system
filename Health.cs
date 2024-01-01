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

        public ArrayList GetConditions() {
            //will return condtions
            return conditions;
        }

        public void AddCondition(Condition condition) {
            conditions.Add(condition);
        }

        public void RemoveCondition(int index) { 
            conditions.Remove(index);
        }

        public void AddHP(int hp) {
            this.hp += hp;
        }

        public void NextTurn() {
            //for each condition
            for (int i = 0; i < conditions.Count; i++) {
                //add what condition returns
                if (conditions[i] != null) {
                    Condition tempCondition = (Condition)conditions[i];
                    hp += tempCondition.HPFormula();
                    
                    //check if still valid and remove if not
                    if (tempCondition.isValid() == false) {
                        //remove from list
                        conditions.RemoveAt(i);
                    }
                }
            }
        }

        public override string ToString() {
            return hp.ToString();
        }
    }
}
