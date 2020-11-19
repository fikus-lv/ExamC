using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Realization
{
	[XmlRoot(ElementName = "Task")]
	public class Task1
	{
		[XmlElement(ElementName = "Id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "Title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "StartDate")]
		public string StartDate { get; set; }
		[XmlElement(ElementName = "EndDate")]
		public string EndDate { get; set; }
		[XmlElement(ElementName = "State")]
		public string State { get; set; }
	}

	[XmlRoot(ElementName = "xml")]
	public class Xml
	{
		[XmlElement(ElementName = "Task")]
		public List<Task> Task { get; set; }
	}

}
