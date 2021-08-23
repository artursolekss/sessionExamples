using System;

namespace Inheritance
{
    interface ILearner
    {
        void Learn();
        void ShareKnowLedge(ILearner anotherLearner);
    }

}