using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "incorrectfeedback")]
    public class Incorrectfeedback {

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
    }
}