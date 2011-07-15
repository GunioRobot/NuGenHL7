using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 QAK message segment. 
	/// This segment has the following fields:</p><p>
	/// QAK-1: Query Tag (ST)<br> 
	/// QAK-2: Query Response Status (ID)<br> 
	/// QAK-3: Message Query Name (CE)<br> 
	/// QAK-4: Hit Count (NM)<br> 
	/// QAK-5: This payload (NM)<br> 
	/// QAK-6: Hits remaining (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class QAK:AbstractSegment
	{
		/// <summary> Returns Query Tag (QAK-1).</summary>
		virtual public ST QueryTag
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Query Response Status (QAK-2).</summary>
		virtual public ID QueryResponseStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Message Query Name (QAK-3).</summary>
		virtual public CE MessageQueryName
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Hit Count (QAK-4).</summary>
		virtual public NM HitCount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns This payload (QAK-5).</summary>
		virtual public NM ThisPayload
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Hits remaining (QAK-6).</summary>
		virtual public NM HitsRemaining
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a QAK (Query Acknowledgment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public QAK(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 208});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}