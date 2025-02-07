using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>The HL7 QSC (query selection criteria) data type.  Consists of the following components: </p><ol>
	/// <li>segment field name (ST)</li>
	/// <li>relational operator (ID)</li>
	/// <li>Value (ST)</li>
	/// <li>relational conjunction (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class QSC:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns segment field name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SegmentFieldName
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns relational operator (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID RelationalOperator
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Value (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Value
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns relational conjunction (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID RelationalConjunction
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a QSC.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public QSC(Message message):base(message)
		{
			data = new Type[4];
			data[0] = new ST(message);
			data[1] = new ID(message, 0);
			data[2] = new ST(message);
			data[3] = new ID(message, 0);
		}
		
		/// <summary> Returns an individual data component.</summary>
		/// <throws>  DataTypeException if the given element number is out of range. </throws>
		public virtual Type getComponent(int number)
		{
			
			try
			{
				return this.data[number];
			}
			catch (IndexOutOfRangeException)
			{
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element QSC composite");
			}
		}
	}
}