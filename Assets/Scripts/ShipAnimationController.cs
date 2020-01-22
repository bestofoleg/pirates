using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnimationController : MonoBehaviour
{
    public class ShipAnimationState
    {
        public const string toRight = "toRight";

        public const string toLeft = "toLeft";

        private const string toFloating = "toFloating";

        private List <string> states;

        private List <string> bufferStatesList;

        private string currentState;

        public ShipAnimationState()
        {
            currentState = toFloating;
            states = new List<string>();
            states.Add(toRight);
            states.Add(toLeft);
            states.Add(toFloating);
            bufferStatesList = new List<string>();
        }

        public void setToRigthState() => currentState = toRight;
        
        public void setToLeftState() => currentState = toLeft;

        public void toFloatingState() => currentState = toFloating;

        public string getCurrentStateName() => currentState;

        public List<string> getStatesWithoutCurrent() => 
            states.FindAll(state => !state.Equals(currentState));

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return currentState.Equals(obj);
        }
        
        public override int GetHashCode()
        {
            return currentState.GetHashCode();
        }

        public override string ToString()
        {
            return currentState;
        }
    }
    
    private Animator shipAnimator;

    private void Awake() {
        shipAnimator = GetComponent<Animator>();
    }

    public void translateToAnimationState(ref ShipAnimationState shipAnimationState)
    {
        shipAnimator.SetBool(shipAnimationState.getCurrentStateName(), true);
        shipAnimationState.getStatesWithoutCurrent()
            .ForEach(state => shipAnimator.SetBool(state, false));
    }


}
