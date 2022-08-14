using System.Collections.Generic;
using System.Xml.Serialization;

namespace moodle_question_exporter.Model {

    [XmlRoot(ElementName = "question")]
    public class Question {

        [XmlElement(ElementName = "name")]
        public Name Name { get; set; }

        [XmlElement(ElementName = "questiontext")]
        public Questiontext Questiontext { get; set; }

        [XmlElement(ElementName = "generalfeedback")]
        public Generalfeedback Generalfeedback { get; set; }

        [XmlElement(ElementName = "defaultgrade")]
        public string Defaultgrade { get; set; }

        [XmlElement(ElementName = "penalty")]
        public string Penalty { get; set; }

        [XmlElement(ElementName = "hidden")]
        public string Hidden { get; set; }

        [XmlElement(ElementName = "single")]
        public string Single { get; set; }

        [XmlElement(ElementName = "shuffleanswers")]
        public string Shuffleanswers { get; set; }

        [XmlElement(ElementName = "answernumbering")]
        public string Answernumbering { get; set; }

        [XmlElement(ElementName = "correctfeedback")]
        public Correctfeedback Correctfeedback { get; set; }

        [XmlElement(ElementName = "partiallycorrectfeedback")]
        public Partiallycorrectfeedback Partiallycorrectfeedback { get; set; }

        [XmlElement(ElementName = "incorrectfeedback")]
        public Incorrectfeedback Incorrectfeedback { get; set; }

        [XmlElement(ElementName = "shownumcorrect")]
        public string Shownumcorrect { get; set; }

        [XmlElement(ElementName = "answer")]
        public List<Answer> Answer { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}