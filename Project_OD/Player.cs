using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OD
{
    public class Player : Entity
    {
        public bool test2 = false;
       

        public int damage;
        private int enemy_Damage;
        public int HP = 10;
        private int armor = 10;
        private bool init = false;
        public bool playerHitEnemy = false;
        public void DamageCalculator(int weaponDamage, int skillDamage, int skillModifier)
        {
            damage = ((weaponDamage + skillDamage) * (1 + skillModifier));
        }
        public void PlayerHP(int HP, int armor, int enemyDamage, bool enemyHit)
        {
            if (init == false)
            {
                SetHP(HP, armor);

                init = true;
            }
            else
            {
                GetHP(enemyDamage, enemyHit);
            }

        }
        public void PlayerAttack()
        {
            playerHitEnemy = true;
        }
        public void Update(int enemyDamage, bool playerGotHit)
        {
            DamageCalculator(1, 0, 0);

            enemy_Damage = enemyDamage;

            PlayerHP(HP, armor, enemyDamage, playerGotHit);

            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.D1))
                PlayerAttack();
                //test2 = true;
            
        }



    }
}
