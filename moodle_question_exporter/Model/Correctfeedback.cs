using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "correctfeedback")]
	public class Correctfeedback {

		[XmlElement(ElementName = "text")]
		public string Text { get; set; }

		[XmlAttribute(AttributeName = "format")]
		public string Format { get; set; }
	}
}