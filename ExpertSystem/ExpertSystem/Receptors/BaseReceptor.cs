using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Receptors
{
    abstract class BaseReceptor
    {
        public int mId;
	    public int mState;

        public BaseReceptor(int id)
	    {
		    this.mId=id;
	    }
	
	    /*
	     * Calculate receptor state in fuzzy logic
	     * @param gameState is a set of states in game scene
	     * @param memory is a list of previous gameStates
	     * @return receptor state
	     */
	    public abstract int getState();

    }
}
