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
    
    public class Entity
    {
        private Vector2 position;
        private int healthPoints;
        public int CurrentHealthPoints;
        public Vector2 Position { get => position; set => position = value; }
        public void SetHP(int HP, int armor)
        {
            healthPoints = HP + armor;
        }
        public void GetHP(int enemyDamage, bool hit)
        {
            if (hit == true)
            {
                healthPoints = healthPoints - enemyDamage;
                healthPoints = CurrentHealthPoints;
            }
            else
            {
                CurrentHealthPoints = healthPoints;
            }

        }

    }
}
