using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Receptors
{
    class ReceptorK
    {
        private int mId;
	    private List<float> mK;
	
	    public ReceptorK(int id, List<float> k)
	    {
		    this.mId=id;
		    this.mK=k;
	    }

	    public int getId() {
		    return mId;
	    }

	    public void setId(int mId) {
		    this.mId = mId;
	    }

	    public List<float> getK() {
		    return mK;
	    }

	    public void setK(List<float> mK) {
		    this.mK = mK;
	    }
    }
}
