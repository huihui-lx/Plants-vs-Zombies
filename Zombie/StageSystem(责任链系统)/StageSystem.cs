using System;
using System.Collections.Generic;
using System.Text;


namespace Zombie
{
    public class StageSystem : IGameSystem
    {
        public int result = 0;//0:进行中 1:成功 -1:失败
        int mLv = 1;
        private int mCountOfEnemyKilled = 0;
        IStageHandler mRootHandler;
        public int countOfEnemyKilled
        {
            set
            {
                mCountOfEnemyKilled = value;
            }
        }
        public override void Init()
        {
            base.Init();
            InitStageChain();
            mFacade.RegisterObserver(GameEventType.EnemyKilled, new EnemyKilledObserverStageSystem(this));
        }

        public override void Update()
        {
            base.Update();
            
            if (mLv > 3)
            {
                result = 1;
            }
            else
            {
                mRootHandler.Handle(mLv);
            }
        }

        private void InitStageChain()
        {

            int lv = 1;
            NormalStageHandler handler1 = new NormalStageHandler(this, lv++, 1, CharacterName.nFlagZombie, 1, 0.05f);
            NormalStageHandler handler2 = new NormalStageHandler(this, lv++, 6, CharacterName.nConeheadZombie, 5, 0.1f);
            NormalStageHandler handler3 = new NormalStageHandler(this, lv++, 12, CharacterName.nBucketheadZombie, 6, 1f);


            handler1.SetNextHandler(handler2)
                .SetNextHandler(handler3);
            mRootHandler = handler1;
        }
        public int CountOfEnemyKilled
        {
            set
            {
                mCountOfEnemyKilled = value;
            }
        }
        public int GetCountOfEnemyKilled()
        {
            return mCountOfEnemyKilled;
        }
        public void EnterNextStage()
        {

            mLv++;
            // mFacade.NotifySubject(GameEventType.NewStage);
        }
    }
}
