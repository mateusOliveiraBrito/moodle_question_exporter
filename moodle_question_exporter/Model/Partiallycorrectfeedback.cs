using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "partiallycorrectfeedback")]
    public class Partiallycorrectfeedback {

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
    }
}