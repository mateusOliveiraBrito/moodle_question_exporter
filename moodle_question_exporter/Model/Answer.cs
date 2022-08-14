using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "answer")]
    public class Answer {

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "fraction")]
        public string Fraction { get; set; }

        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
    }
}