using ExpertSystem.Receptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Reflectors
{
    class BaseReflector
    {
        private String mAction;
	    private float mK;
	    private List<ReceptorK> mReceptorsK;

        public BaseReflector(String action, List<ReceptorK> receptorsK)
	    {
		    mK=0;
		    mAction=action;
		    mReceptorsK=receptorsK;
	    }
	
	    /*
	     * Compute possibility of action
	     * @param receptorsList is a list of receptors
	     */
	    public void estimateK(List<BaseReceptor> receptorsList)
	    {
		    float result=0;
		    for(int i=0; i<mReceptorsK.Count; i++)
		    {
			    int tempIndex=-1;

                for (int j = 0; j < receptorsList.Count; j++)
			    {
				    if(receptorsList[j].mId==mReceptorsK[i].getId())
				    {
					    tempIndex=j;
					    break;
				    }
			    }
			
				    float temp=mReceptorsK[i].getK()[receptorsList[tempIndex].mState]/mReceptorsK.Count;
				    result+=temp*(1-result);
		    }
		
		    mK=result;
	    }
	
	    public String getAction() {
		    return mAction;
	    }

	    public void setAction(String mAction) {
		    this.mAction = mAction;
	    }

	    public float getK() {
		    return mK;
	    }

	    public void setK(float mK) {
		    this.mK = mK;
	    }

	    public List<ReceptorK> getReceptorsK() {
		    return mReceptorsK;
	    }

	    public void setReceptorsK(List<ReceptorK> mReceptorsK) {
		    this.mReceptorsK = mReceptorsK;
	    }
    }
}
