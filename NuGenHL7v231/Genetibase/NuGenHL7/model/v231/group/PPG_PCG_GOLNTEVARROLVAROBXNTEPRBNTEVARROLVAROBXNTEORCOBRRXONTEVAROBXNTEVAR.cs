using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PPG_PCG_GOLNTEVARROLVAROBXNTEPRBNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: GOL (Goal Detail) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: VAR (Variance) <b>optional repeating</b><br>
	/// 3: PPG_PCG_ROLVAR (a Group object) <b>optional repeating</b><br>
	/// 4: PPG_PCG_OBXNTE (a Group object) <b>optional repeating</b><br>
	/// 5: PPG_PCG_PRBNTEVARROLVAROBXNTE (a Group object) <b>optional repeating</b><br>
	/// 6: PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPG_PCG_GOLNTEVARROLVAROBXNTEPRBNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR:AbstractGroup
	{
		/// <summary> Returns GOL (Goal Detail) - creates it if necessary</summary>
		virtual public GOL GOL
		{
			get
			{
				GOL ret = null;
				try
				{
					ret = (GOL) this.get_Renamed("GOL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of VAR </summary>
		virtual public int VARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("VAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_ROLVAR </summary>
		virtual public int ROLVARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ROLVAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_OBXNTE </summary>
		virtual public int OBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_PRBNTEVARROLVAROBXNTE </summary>
		virtual public int PRBNTEVARROLVAROBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRBNTEVARROLVAROBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR </summary>
		virtual public int ORCOBRRXONTEVAROBXNTEVARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCOBRRXONTEVAROBXNTEVAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PPG_PCG_GOLNTEVARROLVAROBXNTEPRBNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR Group.</summary>
		public PPG_PCG_GOLNTEVARROLVAROBXNTEPRBNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(GOL), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
				this.add(typeof(PPG_PCG_ROLVAR), false, true);
				this.add(typeof(PPG_PCG_OBXNTE), false, true);
				this.add(typeof(PPG_PCG_PRBNTEVARROLVAROBXNTE), false, true);
				this.add(typeof(PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of VAR (Variance) - creates it if necessary</summary>
		public virtual VAR getVAR()
		{
			VAR ret = null;
			try
			{
				ret = (VAR) this.get_Renamed("VAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VAR
		/// (Variance) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VAR getVAR(int rep)
		{
			return (VAR) this.get_Renamed("VAR", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_ROLVAR (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_ROLVAR getROLVAR()
		{
			PPG_PCG_ROLVAR ret = null;
			try
			{
				ret = (PPG_PCG_ROLVAR) this.get_Renamed("ROLVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_ROLVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_ROLVAR getROLVAR(int rep)
		{
			return (PPG_PCG_ROLVAR) this.get_Renamed("ROLVAR", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_OBXNTE getOBXNTE()
		{
			PPG_PCG_OBXNTE ret = null;
			try
			{
				ret = (PPG_PCG_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_OBXNTE getOBXNTE(int rep)
		{
			return (PPG_PCG_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_PRBNTEVARROLVAROBXNTE (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_PRBNTEVARROLVAROBXNTE getPRBNTEVARROLVAROBXNTE()
		{
			PPG_PCG_PRBNTEVARROLVAROBXNTE ret = null;
			try
			{
				ret = (PPG_PCG_PRBNTEVARROLVAROBXNTE) this.get_Renamed("PRBNTEVARROLVAROBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_PRBNTEVARROLVAROBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_PRBNTEVARROLVAROBXNTE getPRBNTEVARROLVAROBXNTE(int rep)
		{
			return (PPG_PCG_PRBNTEVARROLVAROBXNTE) this.get_Renamed("PRBNTEVARROLVAROBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR (a Group object) - creates it if necessary</summary>
		public virtual PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR getORCOBRRXONTEVAROBXNTEVAR()
		{
			PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR ret = null;
			try
			{
				ret = (PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR) this.get_Renamed("ORCOBRRXONTEVAROBXNTEVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR getORCOBRRXONTEVAROBXNTEVAR(int rep)
		{
			return (PPG_PCG_ORCOBRRXONTEVAROBXNTEVAR) this.get_Renamed("ORCOBRRXONTEVAROBXNTEVAR", rep);
		}
	}
}