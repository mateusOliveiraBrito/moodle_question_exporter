using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "generalfeedback")]
    public class Generalfeedback {

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
    }
}