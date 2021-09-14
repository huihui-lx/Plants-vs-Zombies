using System;
using System.Collections.Generic;
using System.Text;


namespace Zombie
{
    public class AttrFactory : IAttrFactory
    {
        private Dictionary<Type, CharacterBaseAttr> mCharacterBaseAttrDict;
        public AttrFactory()
        {
            InitCharacterBaseAttr();
        }
        private void InitCharacterBaseAttr()
        {
            mCharacterBaseAttrDict = new Dictionary<Type, CharacterBaseAttr>();
            mCharacterBaseAttrDict.Add(typeof(EnemyZombie), new CharacterBaseAttr("丧尸", 50, 2, 10, 30));  // 最大生命值 移动速度 抵抗力 破坏力
            mCharacterBaseAttrDict.Add(typeof(BotanicRepeater), new CharacterBaseAttr("豌豆射手", 100, 2, 5, 25));
            mCharacterBaseAttrDict.Add(typeof(ConheadZombie), new CharacterBaseAttr("帽子僵尸", 100, 2, 10, 30));
            mCharacterBaseAttrDict.Add(typeof(FlagZombie), new CharacterBaseAttr("领头僵尸", 50, 2, 20, 30));
            mCharacterBaseAttrDict.Add(typeof(BucketheadZombie), new CharacterBaseAttr("铁桶僵尸", 150, 2, 10, 30));
        }
        public CharacterBaseAttr GetCharacterBaseAttr(Type t)
        {
            if (mCharacterBaseAttrDict.ContainsKey(t) == false)
            {
                return null;
            }
            return mCharacterBaseAttrDict[t];
        }
    }
}
