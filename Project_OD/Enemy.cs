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
   public class Enemy : Entity
    {
        public bool test1 = false;

        public int damage;
        private int player_Damage;
        public int HP = 3;
        private int armor = 0;
        private bool init = false;
        public bool enemyHitplayer = false;
        
        public void DamageCalculator(int weaponDamage, int skillDamage, int skillModifier)
        {
            damage = ((weaponDamage + skillDamage) * (1 + skillModifier));
        }
        public void EnemyHP(int HP, int armor, int playerDamage, bool playerHit)
        {
            if (init == false)
            {
                SetHP(HP, armor);

                init = true;
            }
            else
            {

                GetHP(playerDamage, playerHit);
            }
        }
        public void EnemyAttack()
        {
            enemyHitplayer = true;
        }
        public void Update(int playerDamage, bool enemyGotHit)
        {


            player_Damage = playerDamage;
            
            EnemyHP(HP, armor, playerDamage, enemyGotHit);

            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.D2))
                EnemyAttack();
                //test1 = true;
            
        }
    }
}
