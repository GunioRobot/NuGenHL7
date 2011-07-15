using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 OBX message segment. 
	/// This segment has the following fields:</p><p>
	/// OBX-1: Set ID - OBX (SI)<br> 
	/// OBX-2: Value Type (ID)<br> 
	/// OBX-3: Observation Identifier (CE)<br> 
	/// OBX-4: Observation Sub-ID (ST)<br> 
	/// OBX-5: Observation Value (varies)<br> 
	/// OBX-6: Units (CE)<br> 
	/// OBX-7: References Range (ST)<br> 
	/// OBX-8: Abnormal Flags (IS)<br> 
	/// OBX-9: Probability (NM)<br> 
	/// OBX-10: Nature of Abnormal Test (ID)<br> 
	/// OBX-11: Observation Result Status (ID)<br> 
	/// OBX-12: Effective Date of Reference Range (TS)<br> 
	/// OBX-13: User Defined Access Checks (ST)<br> 
	/// OBX-14: Date/Time of the Observation (TS)<br> 
	/// OBX-15: Producer's ID (CE)<br> 
	/// OBX-16: Responsible Observer (XCN)<br> 
	/// OBX-17: Observation Method (CE)<br> 
	/// OBX-18: Equipment Instance Identifier (EI)<br> 
	/// OBX-19: Date/Time of the Analysis (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OBX:AbstractSegment
	{
		/// <summary> Returns Set ID - OBX (OBX-1).</summary>
		virtual public SI SetIDOBX
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
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
		/// <summary> Returns Value Type (OBX-2).</summary>
		virtual public ID ValueType
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
		/// <summary> Returns Observation Identifier (OBX-3).</summary>
		virtual public CE ObservationIdentifier
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
		/// <summary> Returns Observation Sub-ID (OBX-4).</summary>
		virtual public ST ObservationSubID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Units (OBX-6).</summary>
		virtual public CE Units
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns References Range (OBX-7).</summary>
		virtual public ST ReferencesRange
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Probability (OBX-9).</summary>
		virtual public NM Probability
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Observation Result Status (OBX-11).</summary>
		virtual public ID ObservationResultStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Effective Date of Reference Range (OBX-12).</summary>
		virtual public TS EffectiveDateOfReferenceRange
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (TS) t;
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
		/// <summary> Returns User Defined Access Checks (OBX-13).</summary>
		virtual public ST UserDefinedAccessChecks
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Date/Time of the Observation (OBX-14).</summary>
		virtual public TS DateTimeOfTheObservation
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (TS) t;
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
		/// <summary> Returns Producer's ID (OBX-15).</summary>
		virtual public CE ProducerSID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Date/Time of the Analysis (OBX-19).</summary>
		virtual public TS DateTimeOfTheAnalysis
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (TS) t;
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
		
		/// <summary> Creates a OBX (Observation/Result) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OBX(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 125});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(Varies), false, 0, 99999, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 5, new System.Object[]{message, 78});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 80});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 85});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Observation Value (OBX-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual Varies getObservationValue(int rep)
		{
			Varies ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (Varies) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Observation Value (OBX-5).</summary>
		public virtual Varies[] getObservationValue()
		{
			Varies[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new Varies[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (Varies) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Abnormal Flags (OBX-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getAbnormalFlags(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Abnormal Flags (OBX-8).</summary>
		public virtual IS[] getAbnormalFlags()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(8);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Nature of Abnormal Test (OBX-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getNatureOfAbnormalTest(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Nature of Abnormal Test (OBX-10).</summary>
		public virtual ID[] getNatureOfAbnormalTest()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Responsible Observer (OBX-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getResponsibleObserver(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Responsible Observer (OBX-16).</summary>
		public virtual XCN[] getResponsibleObserver()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Observation Method (OBX-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getObservationMethod(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Observation Method (OBX-17).</summary>
		public virtual CE[] getObservationMethod()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(17);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
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
		
		/// <summary> Returns a single repetition of Equipment Instance Identifier (OBX-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getEquipmentInstanceIdentifier(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Equipment Instance Identifier (OBX-18).</summary>
		public virtual EI[] getEquipmentInstanceIdentifier()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(18);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
				}
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
}