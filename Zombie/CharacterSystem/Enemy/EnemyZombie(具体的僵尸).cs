using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Zombie
{
    class EnemyZombie : IEnemy
    {

        public EnemyZombie()
        {
            AtkRange = 10;
            attackimg = "../../images/Zombies/Zombie/ZombieAttack.gif";
            chaseimg = "../../images/Zombies/Zombie/Zombie.gif";
            Image bm = Image.FromFile(chaseimg);
            base.imgheight = bm.Height;
            base.imgwidth = bm.Width;
            bm.Dispose();
        }

        public override void PlayEffect()
        {
            throw new NotImplementedException();
        }
    }

    class ConheadZombie : IEnemy
    {
        public ConheadZombie()
        {
            AtkRange = 10;
            attackimg = "../../images/Zombies/ConeheadZombie/ConeheadZombieAttack.gif";
            chaseimg = "../../images/Zombies/ConeheadZombie/ConeheadZombie.gif";
            Image bm = Image.FromFile(chaseimg);
            base.imgheight = bm.Height;
            base.imgwidth = bm.Width;
            bm.Dispose();
        }
        public override void PlayEffect()
        {
            throw new NotImplementedException();
        }

    }
    class FlagZombie : IEnemy
    {
        public FlagZombie()
        {
            AtkRange = 10;
            attackimg = "../../images/Zombies/FlagZombie/FlagZombieAttack.gif";
            chaseimg = "../../images/Zombies/FlagZombie/FlagZombie.gif";
            Image bm = Image.FromFile(chaseimg);
            base.imgheight = bm.Height;
            base.imgwidth = bm.Width;
            bm.Dispose();
        }
        public override void PlayEffect()
        {
            throw new NotImplementedException();
        }

    }
    class BucketheadZombie : IEnemy
    {
        public BucketheadZombie()
        {
            AtkRange = 10;
            attackimg = "../../images/Zombies/BucketheadZombie/BucketheadZombie.gif";
            chaseimg = "../../images/Zombies/BucketheadZombie/BucketheadZombie.gif";
            Image bm = Image.FromFile(chaseimg);
            base.imgheight = bm.Height;
            base.imgwidth = bm.Width;
            bm.Dispose();
        }
        public override void PlayEffect()
        {
            throw new NotImplementedException();
        }

    }


}
