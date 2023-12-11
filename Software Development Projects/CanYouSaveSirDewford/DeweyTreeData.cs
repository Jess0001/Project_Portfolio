using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Shapes;
using Path = System.IO.Path;
using System.Windows;
using System.DirectoryServices.ActiveDirectory;

namespace CanYouSaveSirDewford
{
    class DeweyTreeData
    {
        //build tree
        //add tree data
        public static DeweyTreeNode<string> GetTreeSet()
        {
            /*DeweyDeweyTreeNode<string> level1=null;
            DeweyDeweyTreeNode<string> level2=null;
            DeweyDeweyTreeNode<string> level3=null;

            string datafile = DeweyData.deweydata;
            /*Tried calling file but it did not work, hence temporarily string in a class for now
            var path = Path.Combine(Directory.GetCurrentDirectory() + (@"\DeweyData.txt"));*/
            
            /*Check if data populated
              MessageBox.Show(datafile);*/

            DeweyTreeNode<string> root = new DeweyTreeNode<string>("root");
            {
                /*foreach (string line in path.Split('\n'))
                {
                    if (line.Contains("•"))
                    {
                        level1 = root.AddChild(line);
                        return level1;
                    }
                    else if (line.Contains("o"))
                    {
                        level2 = level1.AddChild(line);
                        return level2;
                    }
                    else if (line.Contains(""))
                    {
                        level3 = level2.AddChild(line);
                        return level3;
                    }
                }*/
                
                    //tree node -add child- class classifications level 1
                    DeweyTreeNode<string> n000 = root.AddChild("000-Computer science, information, & general works");
                    {
                        //tree node -add child- class classifications level 2
                        DeweyTreeNode<string> nn000 = n000.AddChild("000 Computer science, knowledge and systems");
                        {
                            //tree node -add child- class classifications level 3
                            nn000.AddChild("001 Knowledge");
                            nn000.AddChild("002 The book");
                            nn000.AddChild("003 Systems");
                            nn000.AddChild("004 Data processing Computer science");
                            nn000.AddChild("005 Computer programming, programs, data");
                            nn000.AddChild("006 Special computer methods");
                        }
                        DeweyTreeNode<string> nn010 = n000.AddChild("010 Bibliographies");
                        {
                            nn010.AddChild("010 Bibliography");
                            nn010.AddChild("011 Bibliographies");
                            nn010.AddChild("012 Bibliographies of individuals");
                            nn010.AddChild("013 Bibliographies of works by specific classes of authors");
                            nn010.AddChild("014 Bibliographies of anonymous & pseudonymous works");
                            nn010.AddChild("015 Bibliographies of works from specific places");
                            nn010.AddChild("016 Bibliographies of works from specific subjects");
                            nn010.AddChild("017 General subject catalogs");
                            nn010.AddChild("018 Catalogs arranged by author & date");
                            nn010.AddChild("019 Dictionary catalogs");
                        }
                        DeweyTreeNode<string> nn020 = n000.AddChild("020 Library and information sciences");
                        {
                            nn020.AddChild("020 Library & information sciences");
                            nn020.AddChild("021 Library relationships");
                            nn020.AddChild("022 Administration of the physical plant");
                            nn020.AddChild("023 Personnel administration");
                            nn020.AddChild("025 Library operations");
                            nn020.AddChild("026 Libraries for specific subjects");
                            nn020.AddChild("027 General libraries");
                            nn020.AddChild("028 Reading, use of other information media");
                        }
                        DeweyTreeNode<string> nn030 = n000.AddChild("030 Encyclopedias & books of facts");
                        {
                            nn030.AddChild("030 General encyclopedic works");
                            nn030.AddChild("031 General encyclopedic works — American");
                            nn030.AddChild("032 General encyclopedic works in English");
                            nn030.AddChild("033 General encyclopedic works in other Germanic languages");
                            nn030.AddChild("034 General encyclopedic works in French, Provencal, Catalan");
                            nn030.AddChild("035 General encyclopedic works in Italian, Romanian, Rhaeto - Romanic");
                            nn030.AddChild("036 General encyclopedic works in Spanish & Portuguese");
                            nn030.AddChild("037 General encyclopedic works in Slavic languages");
                            nn030.AddChild("038 General encyclopedic works in Scandinavian languages");
                            nn030.AddChild("039 General encyclopedic works in other languages");
                        }
                        DeweyTreeNode<string> nn050 = n000.AddChild("050 Magazines, journals & serials");
                        {
                            nn050.AddChild("050 General serials & their indexes");
                            nn050.AddChild("051 General serials & their indexes American");
                            nn050.AddChild("052 General serials & their indexes In English");
                            nn050.AddChild("053 General serials & their indexes In other Germanic languages");
                            nn050.AddChild("054 General serials & their indexes In French, Provencal, Catalan");
                            nn050.AddChild("055 General serials & their indexes In Italian, Romanian, Rhaeto - Romanic");
                            nn050.AddChild("056 General serials & their indexes In Spanish & Portuguese");
                            nn050.AddChild("057 General serials & their indexes In Slavic languages");
                            nn050.AddChild("058 General serials & their indexes In Scandinavian languages");
                            nn050.AddChild("059 General serials & their indexes In other languages");
                        }
                        DeweyTreeNode<string> nn060 = n000.AddChild("060 Associations, organizations & museums");
                        {
                            nn060.AddChild("060 General organization & museology");
                            nn060.AddChild("061 General organization & museology In North America");
                            nn060.AddChild("061 General organization & museology In North America");
                            nn060.AddChild("062 General organization & museology In British Isles In England");
                            nn060.AddChild("063 General organization & museology Incentral Europe In Germany");
                            nn060.AddChild("064 General organization & museology In France & Monaco");
                            nn060.AddChild("065 General organization & museology InItaly & adjacentterritories");
                            nn060.AddChild("066 General organization & museology In Iberian Peninsula & adjacentislands");
                            nn060.AddChild("067 General organization & museology In eastern Europe In Soviet Union");
                            nn060.AddChild("068 General organization & museology In other areas");
                            nn060.AddChild("069 Museology(Museumscience)");
                        }
                        DeweyTreeNode<string> nn070 = n000.AddChild("070 News media, journalism & publishing");
                        {
                            nn070.AddChild("070 Newsmedia, journalism, publishing");
                            nn070.AddChild("071 Newsmedia, journalism, publishing In North America");
                            nn070.AddChild("072 Newsmedia, journalism, publishing In British Isles In England");
                            nn070.AddChild("073 Newsmedia, journalism, publishing In central Europe In Germany");
                            nn070.AddChild("074 Newsmedia, journalism, publishing In France & Monaco");
                            nn070.AddChild("075 Newsmedia, journalism, publishing In Italy & adjacentterritories");
                            nn070.AddChild("076 Newsmedia, journalism, publishing In Iberian Peninsula & adjacentislands");
                            nn070.AddChild("077 Newsmedia, journalism, publishing In eastern Europe In Soviet Union");
                            nn070.AddChild("078 Newsmedia, journalism, publishing In Scandinavia");
                            nn070.AddChild("079 Newsmedia, journalism, publishing In other languages");
                        }
                        DeweyTreeNode<string> nn080 = n000.AddChild("080 Quotations");
                        {
                            nn080.AddChild("080 General collections");
                            nn080.AddChild("081 General collections American");
                            nn080.AddChild("082 General collections In English");
                            nn080.AddChild("083 General collections In other Germanic languages");
                            nn080.AddChild("084 General collections In French, Provencal, Catalan");
                            nn080.AddChild("085 General collections In Italian, Romanian, Rhaeto - Romanic");
                            nn080.AddChild("086 General collections In Spanish & Portuguese");
                            nn080.AddChild("087 General collections In Slavic languages");
                            nn080.AddChild("088 General collections In Scandinavian languages");
                            nn080.AddChild("089 General collections In other languages");
                        }
                        DeweyTreeNode<string> nn090 = n000.AddChild("090 Manuscripts & rare books");
                        {
                            nn090.AddChild("090 Manuscripts & rarebooks");
                            nn090.AddChild("091 Manuscripts");
                            nn090.AddChild("092 Blockbooks");
                            nn090.AddChild("093 Incunabula");
                            nn090.AddChild("094 Printed books");
                            nn090.AddChild("095 Books not able for bindings");
                            nn090.AddChild("096 Books not able for illustrations");
                            nn090.AddChild("097 Books not able for ownership or origin");
                            nn090.AddChild("098 Prohibited works, forgeries, hoaxes");
                            nn090.AddChild("099 Books not able for format");
                        }
                    }
                    DeweyTreeNode<string> n100 = root.AddChild("100-Philosophy & psychology");
                    {
                        DeweyTreeNode<string> nn100 = n100.AddChild("100 Philosophy");
                        {
                            nn100.AddChild("100 Philosophy & psychology");
                            nn100.AddChild("101 Theory of philosophy");
                            nn100.AddChild("102 Miscellany of philosophy");
                            nn100.AddChild("103 Dictionaries of philosophy");
                            nn100.AddChild("105 Serial publications of philosophy");
                            nn100.AddChild("106 Organizations of philosophy");
                            nn100.AddChild("107 Education, research in philosophy");
                            nn100.AddChild("108 Kinds of persons in philosophy");
                            nn100.AddChild("109 Historical treatment of philosophy");
                        }
                        DeweyTreeNode<string> nn110 = n100.AddChild("110 Metaphysics");
                        {
                            nn110.AddChild("110 Metaphysics");
                            nn110.AddChild("111 Ontology");
                            nn110.AddChild("113 Cosmology(Philosophyofnature)");
                            nn110.AddChild("114 Space");
                            nn110.AddChild("115 Time");
                            nn110.AddChild("116 Change");
                            nn110.AddChild("117 Structure");
                            nn110.AddChild("118 Force & Energy");
                            nn110.AddChild("119 Number & quantity");
                        }
                        DeweyTreeNode<string> nn120 = n100.AddChild("120 Epistemology");
                        {
                            nn120.AddChild("120 Epistemology, causation, humankind");
                            nn120.AddChild("121 Epistemology(Theoryofknowledge)");
                            nn120.AddChild("122 Causation");
                            nn120.AddChild("123 Determinism & indeterminism");
                            nn120.AddChild("124 Teleology");
                            nn120.AddChild("126 Theself");
                            nn120.AddChild("127 Theunconscious & thesubconscious");
                            nn120.AddChild("128 Humankind");
                            nn120.AddChild("129 Origin & destiny of individual souls");
                        }
                        DeweyTreeNode<string> nn130 = n100.AddChild("130 Parapsychology & occultism");
                        {
                            nn130.AddChild("130 Paranormal phenomena");
                            nn130.AddChild("131 Occult methods for achieving well - being");
                            nn130.AddChild("133 Parapsychology & occultism");
                            nn130.AddChild("135 Dreams & mysteries");
                            nn130.AddChild("137 Divinatory graphology");
                            nn130.AddChild("138 Physiognomy");
                            nn130.AddChild("139 Phrenology");
                        }
                        DeweyTreeNode<string> nn140 = n100.AddChild("140 Philosophical schools of thought");
                        {
                            nn140.AddChild("140 Specific philosophical schools");
                            nn140.AddChild("141 Idealism & related systems");
                            nn140.AddChild("142 Critical philosophy");
                            nn140.AddChild("143 Intuitionism & Bergsonism");
                            nn140.AddChild("144 Humanism & related systems");
                            nn140.AddChild("145 Sensationalism");
                            nn140.AddChild("146 Naturalism & related systems");
                            nn140.AddChild("147 Pantheism & related systems");
                            nn140.AddChild("148 Liberalism, eclecticism, traditionalism");
                            nn140.AddChild("149 Other philosophical systems");
                        }
                        DeweyTreeNode<string> nn150 = n100.AddChild("150 Psychology");
                        {
                            nn150.AddChild("150 Psychology");
                            nn150.AddChild("152 Perception, movement, emotions, drives");
                            nn150.AddChild("153 Mental processes & intelligence");
                            nn150.AddChild("154 Subconscious");
                            nn150.AddChild("155 Differential & developmental psychology");
                            nn150.AddChild("156 Comparative psychology");
                            nn150.AddChild("158 Applied psychology");
                        }
                        DeweyTreeNode<string> nn160 = n100.AddChild("160 Logic");
                        {
                            nn160.AddChild("160 Logic");
                            nn160.AddChild("161 Induction");
                            nn160.AddChild("162 Deduction");
                            nn160.AddChild("165 Fallacies & sources of error");
                            nn160.AddChild("166 Syllogisms");
                            nn160.AddChild("167 Hypotheses");
                            nn160.AddChild("168 Argument & persuasion");
                            nn160.AddChild("169 Analogy");
                        }
                        DeweyTreeNode<string> nn170 = n100.AddChild("170 Ethics");
                        {
                            nn170.AddChild("170 Ethics (Moralphilosophy)");
                            nn170.AddChild("171 Systems & doctrines");
                            nn170.AddChild("172 Political ethics");
                            nn170.AddChild("173 Ethics of family relationships");
                            nn170.AddChild("174 Economic & professional ethics");
                            nn170.AddChild("175 Ethics of recreation & leisure");
                            nn170.AddChild("176 Ethics of sex & reproduction");
                            nn170.AddChild("177 Ethics of social relations");
                            nn170.AddChild("178 Ethics of consumption");
                            nn170.AddChild("179 Other ethical norms");
                        }
                        DeweyTreeNode<string> nn180 = n100.AddChild("180 Ancient, medieval & eastern philosophy");
                        {
                            nn180.AddChild("180 Ancient, medieval, Oriental philosophy");
                            nn180.AddChild("181 Oriental philosophy");
                            nn180.AddChild("182 Pre - Socratic Greek philosophies");
                            nn180.AddChild("183 Sophistic & Socratic philosophies");
                            nn180.AddChild("184 Platonic philosophy");
                            nn180.AddChild("185 Aristotelian philosophy");
                            nn180.AddChild("186 Skeptic & Neoplatonic philosophies");
                            nn180.AddChild("187 Epicurean philosophy");
                            nn180.AddChild("188 Stoic philosophy");
                            nn180.AddChild("189 Medieval Western philosophy");
                        }
                        DeweyTreeNode<string> nn190 = n100.AddChild("190 Modern western philosophy");
                        {
                            nn190.AddChild("190 Modern Western philosophy");
                            nn190.AddChild("191 Modern Western philosophy United States & Canada");
                            nn190.AddChild("192 Modern Western philosophy British Isles");
                            nn190.AddChild("193 Modern Western philosophy Germany & Austria");
                            nn190.AddChild("194 Modern Western philosophy France");
                            nn190.AddChild("195 Modern Western philosophy Italy");
                            nn190.AddChild("196 Modern Western philosophy Spain & Portugal");
                            nn190.AddChild("197 Modern Western philosophy Soviet Union");
                            nn190.AddChild("198 Modern Western philosophy Scandinavia");
                            nn190.AddChild("199 Modern Western philosophy Other geographical areas");
                        }
                    }
                    DeweyTreeNode<string> n200 = root.AddChild("200-Religion");
                    {
                        DeweyTreeNode<string> nn200 = n200.AddChild("200 Religion");
                        {
                            nn200.AddChild("200 Religion");
                            nn200.AddChild("201 Philosophy of Christianity");
                            nn200.AddChild("202 Miscell any of Christianity");
                            nn200.AddChild("203 Dictionaries of Christianity");
                            nn200.AddChild("204 Special topics");
                            nn200.AddChild("205 Serial publications of Christianity");
                            nn200.AddChild("206 Organizations of Christianity");
                            nn200.AddChild("207 Education, research in Christianity");
                            nn200.AddChild("208 Kinds of persons in Christianity");
                            nn200.AddChild("209 History & geography of Christianity");
                        }
                        DeweyTreeNode<string> nn210 = n200.AddChild("210 Philosophy & theory of religion");
                        {
                            nn210.AddChild("210 Natural theology");
                            nn210.AddChild("211 Concepts of God");
                            nn210.AddChild("212 Existence, attributes of God");
                            nn210.AddChild("213 Creation");
                            nn210.AddChild("214 Theodicy");
                            nn210.AddChild("215 Science & religion");
                            nn210.AddChild("216 Good & evil");
                            nn210.AddChild("218 Humankind");

                        }
                        DeweyTreeNode<string> nn220 = n200.AddChild("220 The Bible");
                        {
                            nn220.AddChild("220 Bible");
                            nn220.AddChild("221 Old Testament");
                            nn220.AddChild("222 Historical books of Old Testament");
                            nn220.AddChild("223 Poetic books of Old Testament");
                            nn220.AddChild("224 Prophetic books of Old Testament");
                            nn220.AddChild("225 New Testament");
                            nn220.AddChild("226 Gospels & Acts");
                            nn220.AddChild("227 Epistles");
                            nn220.AddChild("228 Revelation (Apocalypse)");
                            nn220.AddChild("229 Apocrypha & pseudepigrapha");
                        }
                        DeweyTreeNode<string> nn230 = n200.AddChild("230 Christianity & Christian theology");
                        {
                            nn230.AddChild("230 Christian theology");
                            nn230.AddChild("231 God");
                            nn230.AddChild("232 Jesus Christ & his family");
                            nn230.AddChild("233 Humankind");
                            nn230.AddChild("234 Salvation (Soteriology) & grace");
                            nn230.AddChild("235 Spiritual beings");
                            nn230.AddChild("236 Eschatology");
                            nn230.AddChild("238 Creeds & catechisms");
                            nn230.AddChild("239 Apologetics & polemics");
                        }
                        DeweyTreeNode<string> nn240 = n200.AddChild("240 Christian practice & observance");
                        {
                            nn240.AddChild("240 Christian moral & devotional theology");
                            nn240.AddChild("241 Moral theology");
                            nn240.AddChild("242 Devotional literature");
                            nn240.AddChild("243 Evangelistic writings for individuals");
                            nn240.AddChild("245 Texts of hymns");
                            nn240.AddChild("246 Use of art in Christianity");
                            nn240.AddChild("247 Church furnishings & articles");
                            nn240.AddChild("248 Christian experience, practice, life");
                            nn240.AddChild("249 Christian observances in family life");
                        }
                        DeweyTreeNode<string> nn250 = n200.AddChild("250 Christian pastoral practice & religious orders");
                        {
                            nn250.AddChild("250 Christian orders & local church");
                            nn250.AddChild("251 Preaching (Homiletics)");
                            nn250.AddChild("252 Texts of sermons");
                            nn250.AddChild("253 Pastoral office (Pastoral theology)");
                            nn250.AddChild("254 Parish government & administration");
                            nn250.AddChild("255 Religious congregations & orders");
                            nn250.AddChild("259 Activities of the local church");
                        }
                        DeweyTreeNode<string> nn260 = n200.AddChild("260 Christian organization, social work & worship");
                        {
                            nn260.AddChild("260 Christian social theology");
                            nn260.AddChild("261 Social theology");
                            nn260.AddChild("262 Ecclesiology");
                            nn260.AddChild("263 Times, places of religious observance");
                            nn260.AddChild("264 Public worship");
                            nn260.AddChild("265 Sacraments, other rites & acts");
                            nn260.AddChild("266 Missions");
                            nn260.AddChild("267 Associations for religious work");
                            nn260.AddChild("268 Religious education");
                            nn260.AddChild("269 Spiritual renewal");
                        }
                        DeweyTreeNode<string> nn270 = n200.AddChild("270 History of Christianity");
                        {
                            nn270.AddChild("270 Christian church history");
                            nn270.AddChild("271 Religious orders in church history");
                            nn270.AddChild("272 Persecutions in church history");
                            nn270.AddChild("273 Heresies in church history");
                            nn270.AddChild("274 Christian church in Europe");
                            nn270.AddChild("275 Christian church in Asia");
                            nn270.AddChild("276 Christian church in Africa");
                            nn270.AddChild("277 Christian church in North America");
                            nn270.AddChild("278 Christian church in South America");
                            nn270.AddChild("279 Christian church in other areas");
                        }
                        DeweyTreeNode<string> nn280 = n200.AddChild("280 Christian denominations");
                        {
                            nn280.AddChild("280 Christian denominations & sects");
                            nn280.AddChild("281 Early church & Eastern churches");
                            nn280.AddChild("282 Roman Catholic Church");
                            nn280.AddChild("283 Anglican churches");
                            nn280.AddChild("284 Protestants of Continental origin");
                            nn280.AddChild("285 Presbyterian, Reformed, Congregational");
                            nn280.AddChild("286 Baptist, Disciples of Christ, Adventist");
                            nn280.AddChild("287 Methodist & related churches");
                            nn280.AddChild("289 Other denominations & sects");
                        }
                        DeweyTreeNode<string> nn290 = n200.AddChild("290 Other religions");
                        {
                            nn290.AddChild("290 Other & comparativereligions");
                            nn290.AddChild("291 Comparative religion");
                            nn290.AddChild("292 Classical(Greek & Roman)religion");
                            nn290.AddChild("293 Germanic religion");
                            nn290.AddChild("294 Religions of Indic origin");
                            nn290.AddChild("295 Zoroastrianism(Mazdaism, Parseeism)");
                            nn290.AddChild("296 Judaism");
                            nn290.AddChild("297 Islam & religions originating init");
                            nn290.AddChild("299 Other religions");
                        }
                    }
                    DeweyTreeNode<string> n300 = root.AddChild("300–Social sciences");
                    {
                        DeweyTreeNode<string> nn300 = n300.AddChild("300 Social sciences, sociology & anthropology");
                        {
                            nn300.AddChild("300 Social sciences");
                            nn300.AddChild("301 Sociology & anthropology");
                            nn300.AddChild("302 Social interaction");
                            nn300.AddChild("303 Social processes");
                            nn300.AddChild("304 Factors affecting social behavior");
                            nn300.AddChild("305 Social groups");
                            nn300.AddChild("306 Culture & institutions");
                            nn300.AddChild("307 Communities");
                        }
                        DeweyTreeNode<string> nn310 = n300.AddChild("310 Statistics");
                        {
                            nn310.AddChild("310 General statistics");
                            nn310.AddChild("314 General statistics Of Europe");
                            nn310.AddChild("315 General statistics Of Asia");
                            nn310.AddChild("316 General statistics Of Africa");
                            nn310.AddChild("317 General statistics Of North America");
                            nn310.AddChild("318 General statistics Of South America");
                            nn310.AddChild("319 General statistics Of other parts of the world");
                        }
                        DeweyTreeNode<string> nn320 = n300.AddChild("320 Political science");
                        {
                            nn320.AddChild("320 Political science");
                            nn320.AddChild("321 Systems of governments & states");
                            nn320.AddChild("322 Relation of state to organized groups");
                            nn320.AddChild("324 The political process");
                            nn320.AddChild("325 International migration & colonization");
                            nn320.AddChild("326 Slavery & emancipation");
                            nn320.AddChild("327 International relations");
                            nn320.AddChild("328 The legislative process");
                        }
                        DeweyTreeNode<string> nn330 = n300.AddChild("330 Economics");
                        {
                            nn330.AddChild("330 Economics");
                            nn330.AddChild("331 Labor economics");
                            nn330.AddChild("332 Financial economics");
                            nn330.AddChild("333 Land economics");
                            nn330.AddChild("334 Cooperatives");
                            nn330.AddChild("335 Socialism & related systems");
                            nn330.AddChild("336 Public finance");
                            nn330.AddChild("337 International economics");
                            nn330.AddChild("338 Production");
                            nn330.AddChild("339 Macro economics & related topics");
                        }
                        DeweyTreeNode<string> nn340 = n300.AddChild("340 Law");
                        {
                            nn340.AddChild("340 Law");
                            nn340.AddChild("341 International law");
                            nn340.AddChild("342 Constitutional & administrative law");
                            nn340.AddChild("343 Military, tax, trade, industrial law");
                            nn340.AddChild("344 Social, labor, welfare, &related law");
                            nn340.AddChild("345 Criminal law");
                            nn340.AddChild("346 Private law");
                            nn340.AddChild("347 Civil procedure & courts");
                            nn340.AddChild("348 Law(Statutes), regulations, cases");
                            nn340.AddChild("349 Law of specific jurisdictions & areas");
                        }
                        DeweyTreeNode<string> nn350 = n300.AddChild("350 Public administration & military science");
                        {
                            nn350.AddChild("350 Public administration");
                            nn350.AddChild("351 Of central governments");
                            nn350.AddChild("352 Of local governments");
                            nn350.AddChild("353 Of U.S.federal & state governments");
                            nn350.AddChild("354 Of specific central governments");
                            nn350.AddChild("355 Military science");
                            nn350.AddChild("356 Foot forces & warfare");
                            nn350.AddChild("357 Mounted forces & warfare");
                            nn350.AddChild("358 Other specialized forces & services");
                            nn350.AddChild("359 Sea(Naval)forces & warfare");
                        }
                        DeweyTreeNode<string> nn360 = n300.AddChild("360 Social problems & social services");
                        {
                            nn360.AddChild("360 Social services & association");
                            nn360.AddChild("361 General social problems & services");
                            nn360.AddChild("362 Social welfare problems & services");
                            nn360.AddChild("363 Other social problems & services");
                            nn360.AddChild("364 Criminology");
                            nn360.AddChild("365 Penal & related institutions");
                            nn360.AddChild("366 Association");
                            nn360.AddChild("367 General clubs");
                            nn360.AddChild("368 Insurance");
                            nn360.AddChild("369 Miscellaneous kinds of associations");
                        }
                        DeweyTreeNode<string> nn370 = n300.AddChild("370 Education");
                        {
                            nn370.AddChild("370 Education");
                            nn370.AddChild("371 School management & special education");
                            nn370.AddChild("372 Elementary education");
                            nn370.AddChild("373 Secondary education");
                            nn370.AddChild("374 Adult education");
                            nn370.AddChild("375 Curriculums");
                            nn370.AddChild("376 Education of women");
                            nn370.AddChild("377 Schools & religion");
                            nn370.AddChild("378 Higher education");
                            nn370.AddChild("379 Government regulation,control,support");
                        }
                        DeweyTreeNode<string> nn380 = n300.AddChild("380 Commerce, communications & transportation");
                        {
                            nn380.AddChild("380 Commerce, communications & transport");
                            nn380.AddChild("381 Internal commerce (Domestic trade)");
                            nn380.AddChild("382 International commerce (Foreign trade)");
                            nn380.AddChild("383 Postal communication");
                            nn380.AddChild("384 Communications Telecommunication");
                            nn380.AddChild("385 Railroad transportation");
                            nn380.AddChild("386 Inland waterway & ferry transportation");
                            nn380.AddChild("387 Water, air & space transportation");
                            nn380.AddChild("388 Transportation: Ground transportation");
                            nn380.AddChild("389 Metrology & standardization");
                        }
                        DeweyTreeNode<string> nn390 = n300.AddChild("390 Customs, etiquette & folklore");
                        {
                            nn390.AddChild("390 Customs, etiquette & folklore");
                            nn390.AddChild("391 Costume & personal appearance");
                            nn390.AddChild("392 Customs of lifecycle & domestic life");
                            nn390.AddChild("393 Death customs");
                            nn390.AddChild("394 General customs");
                            nn390.AddChild("395 Etiquette (Manners)");
                            nn390.AddChild("398 Folklore");
                            nn390.AddChild("399 Customs of war & diplomacy");
                        }
                    }
                    DeweyTreeNode<string> n400 = root.AddChild("400–Language");
                    {
                        DeweyTreeNode<string> nn400 = n400.AddChild("400 Language");
                        {
                            nn400.AddChild("400 Language");
                            nn400.AddChild("401 Philosophy & theory");
                            nn400.AddChild("402 Miscellany");
                            nn400.AddChild("403 Dictionaries & encyclopedias");
                            nn400.AddChild("404 Special topics");
                            nn400.AddChild("405 Serial publications");
                            nn400.AddChild("406 Organizations & management");
                            nn400.AddChild("407 Education, research, related topics");
                            nn400.AddChild("408 With respect to kinds of persons");
                            nn400.AddChild("409 Geographical & persons treatment");
                        }
                        DeweyTreeNode<string> nn410 = n400.AddChild("410 Linguistics");
                        {
                            nn410.AddChild("410 Linguistics");
                            nn410.AddChild("411 Writing systems");
                            nn410.AddChild("412 Etymology");
                            nn410.AddChild("413 Dictionaries");
                            nn410.AddChild("414 Phonology");
                            nn410.AddChild("415 Structural systems (Grammar)");
                            nn410.AddChild("417 Dialectology & historical linguistics");
                            nn410.AddChild("418 Standard usage Applied linguistics");
                            nn410.AddChild("419 Verbal language not spoken or written");
                        }
                        DeweyTreeNode<string> nn420 = n400.AddChild("420 English & Old English languages");
                        {
                            nn420.AddChild("420 English & Old English");
                            nn420.AddChild("421 English writing system");
                            nn420.AddChild("422 English etymology");
                            nn420.AddChild("423 English dictionaries");
                            nn420.AddChild("425 English grammar");
                            nn420.AddChild("427 English language variations");
                            nn420.AddChild("428 Standard English usage");
                            nn420.AddChild("429 Old English (Anglo - Saxon)");
                        }
                        DeweyTreeNode<string> nn430 = n400.AddChild("430 German & related languages");
                        {
                            nn430.AddChild("430 Germanic languages German");
                            nn430.AddChild("431 German writing system & phonology");
                            nn430.AddChild("432 German etymology");
                            nn430.AddChild("433 German dictionaries");
                            nn430.AddChild("435 German grammar");
                            nn430.AddChild("437 German language variations");
                            nn430.AddChild("438 Standard German usage");
                            nn430.AddChild("439 Other Germanic languages");
                        }
                        DeweyTreeNode<string> nn440 = n400.AddChild("440 French & related languages");
                        {
                            nn440.AddChild("440 Romance languages French");
                            nn440.AddChild("441 French writing system & phonology");
                            nn440.AddChild("442 French etymology");
                            nn440.AddChild("443 French dictionaries");
                            nn440.AddChild("445 French grammar");
                            nn440.AddChild("447 French language variations");
                            nn440.AddChild("448 Standard French usage");
                            nn440.AddChild("449 Provencal & Catalan");
                        }
                        DeweyTreeNode<string> nn450 = n400.AddChild("450 Italian, Romanian & related languages");
                        {
                            nn450.AddChild("450 Italian, Romanian & Rhaeto-Romantic");
                            nn450.AddChild("451 Italian writing system & phonology");
                            nn450.AddChild("452 Italian etymology");
                            nn450.AddChild("453 Italian dictionaries");
                            nn450.AddChild("455 Italian grammar");
                            nn450.AddChild("457 Italian language variations");
                            nn450.AddChild("458 Standard Italian usage");
                            nn450.AddChild("459 Romanian & Rhaeto - Romanic");
                        }
                        DeweyTreeNode<string> nn460 = n400.AddChild("460 Spanish & Portuguese languages");
                        {
                            nn460.AddChild("460 Spanish & Portugese languages");
                            nn460.AddChild("461 Spanish writing system & phonology");
                            nn460.AddChild("462 Spanish etymology");
                            nn460.AddChild("463 Spanish dictionaries");
                            nn460.AddChild("465 Spanish grammar");
                            nn460.AddChild("467 Spanish language variations");
                            nn460.AddChild("468 Standard Spanish usage");
                            nn460.AddChild("469 Portuguese");
                        }
                        DeweyTreeNode<string> nn470 = n400.AddChild("470 Latin & Italic languages");
                        {
                            nn470.AddChild("470 Italic Latin");
                            nn470.AddChild("471 Classical Latin writing & phonology");
                            nn470.AddChild("472 Classical Latin etymology & phonology");
                            nn470.AddChild("473 Classical Latin dictionaries");
                            nn470.AddChild("475 Classical Latin grammar");
                            nn470.AddChild("477 Old, Post classical, Vulgar Latin");
                            nn470.AddChild("478 Classical Latinusage");
                            nn470.AddChild("479 Other Italic languages");
                        }
                        DeweyTreeNode<string> nn480 = n400.AddChild("480 Classical & modern Greek languages");
                        {
                            nn480.AddChild("480 Hellenic languages Classical Greek");
                            nn480.AddChild("481 Classical Greek writing & phonology");
                            nn480.AddChild("482 Classical Greek etymology");
                            nn480.AddChild("483 Classical Greek dictionaries");
                            nn480.AddChild("485 Classical Greek grammar");
                            nn480.AddChild("487 Pre classical & post classical Greek");
                            nn480.AddChild("488 Classical Gree kusage");
                            nn480.AddChild("489 Other Hellenic languages");
                        }
                        DeweyTreeNode<string> nn490 = n400.AddChild("490 Other language");
                        {
                            nn490.AddChild("490 Other languages");
                            nn490.AddChild("491 East Indo - European & Celtic languages");
                            nn490.AddChild("492 Afro - Asiatic languages Semitic");
                            nn490.AddChild("493 Non - Semitic Afro - Asiatic languages");
                            nn490.AddChild("494 Ural - Altaic, Paleosiberian, Dravidian");
                            nn490.AddChild("495 Languages of East & Southeast Asia");
                            nn490.AddChild("496 African languages");
                            nn490.AddChild("497 North American native languages");
                            nn490.AddChild("498 South American native languages");
                            nn490.AddChild("499 Miscellaneous languages");
                        }
                    }
                    DeweyTreeNode<string> n500 = root.AddChild("500-Science");
                    {
                        DeweyTreeNode<string> nn500 = n500.AddChild("500 Science");
                        {
                            nn500.AddChild("500 Natural sciences & mathematics");
                            nn500.AddChild("501 Philosophy & theory");
                            nn500.AddChild("502 Miscellany");
                            nn500.AddChild("503 Dictionaries & encyclopedias");
                            nn500.AddChild("505 Serial publications");
                            nn500.AddChild("506 Organizations & management");
                            nn500.AddChild("507 Education, research, related topics");
                            nn500.AddChild("508 Naturalhistory");
                            nn500.AddChild("509 Historical, areas, persons treatment");
                        }
                        DeweyTreeNode<string> nn510 = n500.AddChild("510 Mathematics");
                        {
                            nn510.AddChild("510 Mathematics");
                            nn510.AddChild("511 General principles");
                            nn510.AddChild("512 Algebra & number theory");
                            nn510.AddChild("513 Arithmetic");
                            nn510.AddChild("514 Topology");
                            nn510.AddChild("515 Analysis");
                            nn510.AddChild("516 Geometry");
                            nn510.AddChild("519 Probabilities & applied mathematics");
                        }
                        DeweyTreeNode<string> nn520 = n500.AddChild("520 Astronomy");
                        {
                            nn520.AddChild("520 Astronomy & allied sciences");
                            nn520.AddChild("521 Celestial mechanics");
                            nn520.AddChild("522 Techniques, equipment, materials");
                            nn520.AddChild("523 Specific celestial bodies & phenomena");
                            nn520.AddChild("525 Earth (Astronomical geography)");
                            nn520.AddChild("526 Mathematical geography");
                            nn520.AddChild("527 Celestial navigation");
                            nn520.AddChild("528 Ephemerides");
                            nn520.AddChild("529 Chronology");
                        }
                        DeweyTreeNode<string> nn530 = n500.AddChild("530 Physics");
                        {
                            nn530.AddChild("530 Physics");
                            nn530.AddChild("531 Classical mechanics Solid mechanics");
                            nn530.AddChild("532 Fluid mechanics Liquid mechanics");
                            nn530.AddChild("533 Gas mechanics");
                            nn530.AddChild("534 Sound & related vibrations");
                            nn530.AddChild("535 Light & paraphotic phenomena");
                            nn530.AddChild("536 Heat");
                            nn530.AddChild("537 Electricity & electronics");
                            nn530.AddChild("538 Magnetism");
                            nn530.AddChild("539 Modern physics");
                        }
                        DeweyTreeNode<string> nn540 = n500.AddChild("540 Chemistry");
                        {
                            nn540.AddChild("540 Chemistry & allied sciences");
                            nn540.AddChild("541 Physical & theoreticalchemistry");
                            nn540.AddChild("542 Techniques, equipment, materials");
                            nn540.AddChild("543 Analytical chemistry");
                            nn540.AddChild("544 Qualitative analysis");
                            nn540.AddChild("545 Quantitative analysis");
                            nn540.AddChild("546 Inorganic chemistry");
                            nn540.AddChild("547 Organic chemistry");
                            nn540.AddChild("548 Crystallography");
                            nn540.AddChild("549 Mineralogy");
                        }
                        DeweyTreeNode<string> nn550 = n500.AddChild("550 Earth sciences & geology");
                        {
                            nn550.AddChild("550 Earth sciences");
                            nn550.AddChild("551 Geology, hydrology, meteorology");
                            nn550.AddChild("552 Petrology");
                            nn550.AddChild("553 Economic geology");
                            nn550.AddChild("554 Earth sciences of Europe");
                            nn550.AddChild("555 Earth sciences of Asia");
                            nn550.AddChild("556 Earth sciences of Africa");
                            nn550.AddChild("557 Earth sciences of North America");
                            nn550.AddChild("558 Earth sciences of South America");
                            nn550.AddChild("559 Earth sciences of other areas");
                        }
                        DeweyTreeNode<string> nn560 = n500.AddChild("560 Fossils & prehistoric life");
                        {
                            nn560.AddChild("560 Paleontology Paleozoology");
                            nn560.AddChild("561 Paleobotany");
                            nn560.AddChild("562 Fossil invertebrates");
                            nn560.AddChild("563 Fossil primitivephyla");
                            nn560.AddChild("564 Fossil Mollusca & Molluscoidea");
                            nn560.AddChild("565 Other fossil invertebrates");
                            nn560.AddChild("566 Fossil Vertebrata (Fossil Craniata)");
                            nn560.AddChild("567 Fossil cold - blooded vertebrates");
                            nn560.AddChild("568 Fossi lAves (Fossil birds)");
                            nn560.AddChild("569 Fossil Mammalia");
                        }
                        DeweyTreeNode<string> nn570 = n500.AddChild("570 Life sciences; biology");
                        {
                            nn570.AddChild("570 Life sciences");
                            nn570.AddChild("572 Biochemistry");
                            nn570.AddChild("573 Physical anthropology");
                            nn570.AddChild("574 Biology");
                            nn570.AddChild("575 Evolution & genetics");
                            nn570.AddChild("576 Microbiology");
                            nn570.AddChild("577 General nature of life");
                            nn570.AddChild("578 Microscopy in biology");
                            nn570.AddChild("579 Collection & preservation");
                            nn570.AddChild("");
                        }
                        DeweyTreeNode<string> nn580 = n500.AddChild("580 Plants (Botany)");
                        {
                            nn580.AddChild("580 Botanical sciences");
                            nn580.AddChild("581 Botany");
                            nn580.AddChild("582 Spermatophyta (Seed - bearing plants)");
                            nn580.AddChild("583 Dicotyledones");
                            nn580.AddChild("584 Monocotyledones");
                            nn580.AddChild("585 Gymnospermae (Pinophyta)");
                            nn580.AddChild("586 Cryptogamia (Seedless plants)");
                            nn580.AddChild("587 Pteridophyta (Vascular cryptograms)");
                            nn580.AddChild("588 Bryophyta");
                            nn580.AddChild("589 Thallobionta & Prokaryotae");
                        }
                        DeweyTreeNode<string> nn590 = n500.AddChild("590 Animals (Zoology)");
                        {
                            nn590.AddChild("590 Zoological sciences");
                            nn590.AddChild("591 Zoology");
                            nn590.AddChild("592 Invertebrates");
                            nn590.AddChild("593 Protozoa, Echinodermata, related phyla");
                            nn590.AddChild("594 Mollusca & Molluscoidea");
                            nn590.AddChild("595 Other invertebrates");
                            nn590.AddChild("596 Vertebrata (Craniata, Vertebrates)");
                            nn590.AddChild("597 Cold - blooded vertebrates Fishes");
                            nn590.AddChild("598 Aves (Birds)");
                            nn590.AddChild("599 Mammalia (Mammals)");
                        }
                    }
                    DeweyTreeNode<string> n600 = root.AddChild("600-Technology");
                    {
                        DeweyTreeNode<string> nn600 = n600.AddChild("600 Technology");
                        {
                            nn600.AddChild("600 Technology (Applied sciences)");
                            nn600.AddChild("601 Philosophy & theory");
                            nn600.AddChild("602 Miscellany");
                            nn600.AddChild("603 Dictionaries & encyclopedias");
                            nn600.AddChild("604 Specialtopics");
                            nn600.AddChild("605 Serial publications");
                            nn600.AddChild("606 Organizations");
                            nn600.AddChild("607 Education, research, related topics");
                            nn600.AddChild("608 Invention & patents");
                            nn600.AddChild("609 Historical, areas, persons treatment");
                        }
                        DeweyTreeNode<string> nn610 = n600.AddChild("610 Medicine & health");
                        {
                            nn610.AddChild("610 Medical sciences Medicine");
                            nn610.AddChild("611 Humananatomy, cytology, histology");
                            nn610.AddChild("612 Human physiology");
                            nn610.AddChild("613 Promotion of health");
                            nn610.AddChild("614 Incidence & prevention of disease");
                            nn610.AddChild("615 Pharmacology & theraputics");
                            nn610.AddChild("616 Diseases");
                            nn610.AddChild("617 Surgery & related medical specialities");
                            nn610.AddChild("618 Gynecology & other medical specialities");
                            nn610.AddChild("619 Experimental medicine");
                        }
                        DeweyTreeNode<string> nn620 = n600.AddChild("620 Engineering");
                        {
                            nn620.AddChild("620 Engineering & allied operations");
                            nn620.AddChild("621 Applied physics");
                            nn620.AddChild("622 Mining & related operations");
                            nn620.AddChild("623 Military & nautical engineering");
                            nn620.AddChild("624 Civil engineering");
                            nn620.AddChild("625 Engineering of railroads, roads");
                            nn620.AddChild("627 Hydraulic engineering");
                            nn620.AddChild("628 Sanitary & municipal engineering");
                            nn620.AddChild("629 Other branches of engineering");

                        }
                        DeweyTreeNode<string> nn630 = n600.AddChild("630 Agriculture");
                        {
                            nn630.AddChild("630 Agriculture");
                            nn630.AddChild("631 Techniques, equipment, materials");
                            nn630.AddChild("632 Plantinjuries, diseases, pests");
                            nn630.AddChild("633 Field & plantation crops");
                            nn630.AddChild("634 Orchards, fruits, forestry");
                            nn630.AddChild("635 Garden crops (Horticulture)");
                            nn630.AddChild("636 Animal husbandry");
                            nn630.AddChild("637 Processing dairy & related products");
                            nn630.AddChild("638 Insect culture");
                            nn630.AddChild("639 Hunting, fishing, conservation");
                        }
                        DeweyTreeNode<string> nn640 = n600.AddChild("640 Home & family management");
                        {
                            nn640.AddChild("640 Home economics &family living");
                            nn640.AddChild("641 Food & drink");
                            nn640.AddChild("642 Meals & table service");
                            nn640.AddChild("643 Housing & household equipment");
                            nn640.AddChild("644 Household utilities");
                            nn640.AddChild("645 Household furnishings");
                            nn640.AddChild("646 Sewing, clothing, personal living");
                            nn640.AddChild("647 Management of public households");
                            nn640.AddChild("648 Housekeeping");
                            nn640.AddChild("649 Child rearing & homecare of sick");
                        }
                        DeweyTreeNode<string> nn650 = n600.AddChild("650 Management & public relations");
                        {
                            nn650.AddChild("650 Management & auxiliary services");
                            nn650.AddChild("651 Office services");
                            nn650.AddChild("652 Processes of written communication");
                            nn650.AddChild("653 Shorthand");
                            nn650.AddChild("657 Accounting");
                            nn650.AddChild("658 General management");
                            nn650.AddChild("659 Advertising & public relations");
                        }
                        DeweyTreeNode<string> nn660 = n600.AddChild("660 Chemical engineering");
                        {
                            nn660.AddChild("660 Chemical engineering");
                            nn660.AddChild("661 Industrial chemicals technology");
                            nn660.AddChild("662 Explosives, fuels technology");
                            nn660.AddChild("663 Beverage technology");
                            nn660.AddChild("664 Food technology");
                            nn660.AddChild("665 Industrial oils, fats, waxes, gases");
                            nn660.AddChild("666 Ceramic & allied technologies");
                            nn660.AddChild("667 Cleaning, color, related technologies");
                            nn660.AddChild("668 Technology o fother organic products");
                            nn660.AddChild("669 Metallurgy");
                        }
                        DeweyTreeNode<string> nn670 = n600.AddChild("670 Manufacturing");
                        {
                            nn670.AddChild("670 Manufacturing");
                            nn670.AddChild("671 Metal working & metal products");
                            nn670.AddChild("672 Iron, steel, other ironalloys");
                            nn670.AddChild("673 Non-ferrous metals");
                            nn670.AddChild("674 Lumber processing, wood products, cork");
                            nn670.AddChild("675 Leather & fur processing");
                            nn670.AddChild("676 Pulp & paper technology");
                            nn670.AddChild("677 Textiles");
                            nn670.AddChild("678 Elastomers & elastomer products");
                            nn670.AddChild("679 Other products of specific materials");
                        }
                        DeweyTreeNode<string> nn680 = n600.AddChild("680 Manufacture for specific uses");
                        {
                            nn680.AddChild("680 Manufacture for specific uses");
                            nn680.AddChild("681 Precision instruments & other devices");
                            nn680.AddChild("682 Small forgework (Blacksmithing)");
                            nn680.AddChild("683 Hardware & household appliances");
                            nn680.AddChild("684 Furnishings & homeworkshops");
                            nn680.AddChild("685 Leather, fur, related products");
                            nn680.AddChild("686 Printing & related activities");
                            nn680.AddChild("687 Clothing");
                            nn680.AddChild("688 Other final products & packaging");
                        }
                        DeweyTreeNode<string> nn690 = n600.AddChild("690 Building & construction");
                        {
                            nn690.AddChild("690 Buildings");
                            nn690.AddChild("691 Building materials");
                            nn690.AddChild("692 Auxiliary construction practices");
                            nn690.AddChild("693 Specific materials & purposes");
                            nn690.AddChild("694 Wood construction Carpentry");
                            nn690.AddChild("695 Roof covering");
                            nn690.AddChild("696 Utilities");
                            nn690.AddChild("697 Heating, ventilating, air - conditioning");
                            nn690.AddChild("698 Detail finishing");
                        }
                    }
                    DeweyTreeNode<string> n700 = root.AddChild("700-Arts & recreation");
                    {
                        DeweyTreeNode<string> nn700 = n700.AddChild("700 Arts");
                        {
                            nn700.AddChild("700 Thearts");
                            nn700.AddChild("701 Philosophy & theory");
                            nn700.AddChild("702 Miscellany");
                            nn700.AddChild("703 Dictionaries & encyclopedias");
                            nn700.AddChild("704 Special topics");
                            nn700.AddChild("705 Serial publications");
                            nn700.AddChild("706 Organizations & management");
                            nn700.AddChild("707 Education, research, related topics");
                            nn700.AddChild("708 Galleries, museums, private collections");
                            nn700.AddChild("709 Historical, areas, persons treatment");
                        }
                        DeweyTreeNode<string> nn710 = n700.AddChild("710 Landscaping & area planning");
                        {
                            nn710.AddChild("710 Civic & landscape art");
                            nn710.AddChild("711 Area planning (Civic art)");
                            nn710.AddChild("712 Landscape architecture");
                            nn710.AddChild("713 Landscape architecture of traffic ways");
                            nn710.AddChild("714 Water features");
                            nn710.AddChild("715 Woody plants");
                            nn710.AddChild("716 Herbaceous plants");
                            nn710.AddChild("717 Structures");
                            nn710.AddChild("718 Landscape design of cemeteries");
                            nn710.AddChild("719 Natural landscapes");
                        }
                        DeweyTreeNode<string> nn720 = n700.AddChild("720 Architecture");
                        {
                            nn720.AddChild("720 Architecture");
                            nn720.AddChild("721 Architectural structure");
                            nn720.AddChild("722 Architecture to ca.300");
                            nn720.AddChild("723 Architecture from ca.300 to 1399");
                            nn720.AddChild("724 Architecture from 1400");
                            nn720.AddChild("725 Public structures");
                            nn720.AddChild("726 Buildings for religious purposes");
                            nn720.AddChild("727 Buildings for education & research");
                            nn720.AddChild("728 Residential & related buildings");
                            nn720.AddChild("729 Design & decoration");
                        }
                        DeweyTreeNode<string> nn730 = n700.AddChild("730 Sculpture, ceramics & metalwork");
                        {
                            nn730.AddChild("730 Plastic arts Sculpture");
                            nn730.AddChild("731 Processes, forms, subjects of sculpture");
                            nn730.AddChild("732 Sculpture to ca.500");
                            nn730.AddChild("733 Greek, Etruscan, Roman sculpture");
                            nn730.AddChild("734 Sculpture from ca.500 to 1399");
                            nn730.AddChild("735 Sculpture from 1400");
                            nn730.AddChild("736 Carving & carvings");
                            nn730.AddChild("737 Numismatics & sigillography");
                            nn730.AddChild("738 Ceramic arts");
                            nn730.AddChild("739 Artmetal work");
                        }
                        DeweyTreeNode<string> nn740 = n700.AddChild("740 Drawing & decorative arts");
                        {
                            nn740.AddChild("740 Drawing & decorative arts");
                            nn740.AddChild("741 Drawing & drawings");
                            nn740.AddChild("742 Perspective");
                            nn740.AddChild("743 Drawing & drawings by subject");
                            nn740.AddChild("745 Decorative arts");
                            nn740.AddChild("746 Textile arts");
                            nn740.AddChild("747 Interior decoration");
                            nn740.AddChild("748 Glass");
                            nn740.AddChild("749 Furniture & accessories");
                        }
                        DeweyTreeNode<string> nn750 = n700.AddChild("750 Painting");
                        {
                            nn750.AddChild("750 Painting & paintings");
                            nn750.AddChild("751 Techniques, equipment, forms");
                            nn750.AddChild("752 Color");
                            nn750.AddChild("753 Symbolism, allegory, mythology, legend");
                            nn750.AddChild("754 Genre paintings");
                            nn750.AddChild("755 Religion & religious symbolism");
                            nn750.AddChild("757 Human figures & their parts");
                            nn750.AddChild("758 Other subjects");
                            nn750.AddChild("759 Historical, areas, persons treatment");
                        }
                        DeweyTreeNode<string> nn760 = n700.AddChild("760 Graphic arts");
                        {
                            nn760.AddChild("760 Graphic arts Print making & prints");
                            nn760.AddChild("761 Relief processes (Blockprinting)");
                            nn760.AddChild("763 Lithographic (Planographic) processes");
                            nn760.AddChild("764 Chromolithography & serigraphy");
                            nn760.AddChild("765 Metalengraving");
                            nn760.AddChild("766 Mezzotinting & related processes");
                            nn760.AddChild("767 Etching & drypoint");
                            nn760.AddChild("769 Prints");
                        }
                        DeweyTreeNode<string> nn770 = n700.AddChild("770 Photography & computer art");
                        {
                            nn770.AddChild("770 Photography & photographs");
                            nn770.AddChild("771 Techniques, equipment, materials");
                            nn770.AddChild("772 Metallicsalt processes");
                            nn770.AddChild("773 Pigment processes of printing");
                            nn770.AddChild("774 Holography");
                            nn770.AddChild("778 Fields & kinds of photography");
                            nn770.AddChild("779 Photographs");
                        }
                        DeweyTreeNode<string> nn780 = n700.AddChild("780 Music");
                        {
                            nn780.AddChild("780 Music");
                            nn780.AddChild("781 General principles & musical forms");
                            nn780.AddChild("782 Vocal music");
                            nn780.AddChild("783 Music for single voices The voice");
                            nn780.AddChild("784 Instruments & Instrumental ensembles");
                            nn780.AddChild("785 Chamber music");
                            nn780.AddChild("786 Keyboard & other instruments");
                            nn780.AddChild("787 Stringed instruments (Chordophones)");
                            nn780.AddChild("788 Wind instruments (Aerophones)");
                        }
                        DeweyTreeNode<string> nn790 = n700.AddChild("790 Sports, games & entertainment");
                        {
                            nn790.AddChild("790 Recreational & performing arts");
                            nn790.AddChild("791 Public performances");
                            nn790.AddChild("792 Stage presentations");
                            nn790.AddChild("793 Indoor games & amusements");
                            nn790.AddChild("794 Indoor games of skill");
                            nn790.AddChild("795 Games of chance");
                            nn790.AddChild("796 Athletic & outdoor sports & games");
                            nn790.AddChild("797 Aquatic & air sports");
                            nn790.AddChild("798 Equestrian sports & animal racing");
                            nn790.AddChild("799 Fishing, hunting, shooting");
                        }
                    }
                    DeweyTreeNode<string> n800 = root.AddChild("800-Literature");
                    {
                        DeweyTreeNode<string> nn800 = n800.AddChild("800 Literature, rhetoric & criticism");
                        {
                            nn800.AddChild("800 Literature & rhetoric");
                            nn800.AddChild("801 Philosophy & theory");
                            nn800.AddChild("802 Miscellany");
                            nn800.AddChild("803 Dictionaries & encyclopedias");
                            nn800.AddChild("805 Serial publications");
                            nn800.AddChild("806 Organizations & management");
                            nn800.AddChild("807 Education, research, related topics");
                            nn800.AddChild("808 Rhetoric & collections of literature");
                            nn800.AddChild("809 Literary history & criticism");
                        }
                        DeweyTreeNode<string> nn810 = n800.AddChild("810 American literature in English");
                        {
                            nn810.AddChild("810 American literature in English");
                            nn810.AddChild("811 American poetry in English");
                            nn810.AddChild("812 American drama in English");
                            nn810.AddChild("813 American fiction in English");
                            nn810.AddChild("814 American essays in English");
                            nn810.AddChild("815 American speeches in English");
                            nn810.AddChild("816 American letters in English");
                            nn810.AddChild("817 American humor & satire in English");
                            nn810.AddChild("818 American miscellaneous writings in English");

                        }
                        DeweyTreeNode<string> nn820 = n800.AddChild("820 English & Old English literatures");
                        {
                            nn820.AddChild("820 English & Old English (Anglo-Saxon) literatures");
                            nn820.AddChild("821 English poetry");
                            nn820.AddChild("822 English drama");
                            nn820.AddChild("823 English fiction");
                            nn820.AddChild("824 English essays");
                            nn820.AddChild("825 English speeches");
                            nn820.AddChild("826 English letters");
                            nn820.AddChild("827 English satire & humor");
                            nn820.AddChild("828 English miscellaneous writings");
                            nn820.AddChild("829 Old English (Anglo - Saxon) literature");
                        }
                        DeweyTreeNode<string> nn830 = n800.AddChild("830 German & related literatures");
                        {
                            nn830.AddChild("830 German literature & literatures of related languages");
                            nn830.AddChild("831 German poetry");
                            nn830.AddChild("832 German drama");
                            nn830.AddChild("833 German fiction");
                            nn830.AddChild("834 German essays");
                            nn830.AddChild("835 German speeches");
                            nn830.AddChild("836 German letters");
                            nn830.AddChild("837 German humor & satire");
                            nn830.AddChild("838 German miscellaneous writings");
                            nn830.AddChild("839 Other Germanic literatures");
                        }
                        DeweyTreeNode<string> nn840 = n800.AddChild("840 French & related literatures");
                        {
                            nn840.AddChild("840 French literature & literatures of related Romance languages");
                            nn840.AddChild("841 French poetry");
                            nn840.AddChild("842 French drama");
                            nn840.AddChild("843 French fiction");
                            nn840.AddChild("844 French essays");
                            nn840.AddChild("845 French speeches");
                            nn840.AddChild("846 French letters");
                            nn840.AddChild("847 French humor & satire");
                            nn840.AddChild("848 French miscellaneous writings");
                            nn840.AddChild("849 Occitan, Catalan, Franco - Provençal literatures");
                        }
                        DeweyTreeNode<string> nn850 = n800.AddChild("850 Italian, Romanian & related literatures");
                        {
                            nn850.AddChild("850 Literatures of Italian, Dalmatian, Romanian, Rhaetian, Sardinian, Corsican languages");
                            nn850.AddChild("851 Italian poetry");
                            nn850.AddChild("852 Italian drama");
                            nn850.AddChild("853 Italian fiction");
                            nn850.AddChild("854 Italian essays");
                            nn850.AddChild("855 Italian speeches");
                            nn850.AddChild("856 Italian letters");
                            nn850.AddChild("857 Italian humor & satire");
                            nn850.AddChild("858 Italian miscellaneous writings");
                            nn850.AddChild("859 Literatures of Romanian, Rhaetian, Sardinian, Corsican languages");
                        }
                        DeweyTreeNode<string> nn860 = n800.AddChild("860 Spanish & Portuguese literatures");
                        {
                            nn860.AddChild("860 Literatures of Spanish, Portuguese, Galician languages");
                            nn860.AddChild("861 Spanish poetry");
                            nn860.AddChild("862 Spanish drama");
                            nn860.AddChild("863 Spanish fiction");
                            nn860.AddChild("864 Spanish essays");
                            nn860.AddChild("865 Spanish speeches");
                            nn860.AddChild("866 Spanish letters");
                            nn860.AddChild("867 Spanish humor & satire");
                            nn860.AddChild("868 Spanish miscellaneous writings");
                            nn860.AddChild("869 Literatures of Portuguese & Galician languages");
                        }
                        DeweyTreeNode<string> nn870 = n800.AddChild("870 Latin & Italic literatures");
                        {
                            nn870.AddChild("870 Latin literature and literatures of related Italic languages");
                            nn870.AddChild("871 Latin poetry");
                            nn870.AddChild("872 Latin dramatic poetry and drama");
                            nn870.AddChild("873 Latin epic poetry and fiction");
                            nn870.AddChild("874 Latin lyric poetry");
                            nn870.AddChild("875 Latin speeches");
                            nn870.AddChild("876 Latin letters");
                            nn870.AddChild("877 Latin humor & satire");
                            nn870.AddChild("878 Latin miscellaneous writings");
                            nn870.AddChild("879 Literatures of other Italic languages");
                        }
                        DeweyTreeNode<string> nn880 = n800.AddChild("880 Classical & modern Greek literatures");
                        {
                            nn880.AddChild("880 Classical Greek literature & literatures of related Hellenic languages");
                            nn880.AddChild("881 Classical Greek poetry");
                            nn880.AddChild("882 Classical Greek drama");
                            nn880.AddChild("883 Classical Greek epic poetry & fiction");
                            nn880.AddChild("884 Classical Greek lyric poetry");
                            nn880.AddChild("885 Classical Greek speeches");
                            nn880.AddChild("886 Classical Greek letters");
                            nn880.AddChild("887 Classical Greek humor & satire");
                            nn880.AddChild("888 Classical Greek miscellaneous writings");
                            nn880.AddChild("889 Modern Greek literature");
                        }
                        DeweyTreeNode<string> nn890 = n800.AddChild("890 Other literatures");
                        {
                            nn890.AddChild("890 Literatures of other specific languages & language families");
                            nn890.AddChild("891 East Indo - European & Celtic literatures");
                            nn890.AddChild("892 Afro - Asiatic literatures");
                            nn890.AddChild("893 Non - Semitic Afro - Asiatic literatures");
                            nn890.AddChild("894 Literatures of Altaic, Uralic, Hyperborean, Dravidian languages; literatures of miscellaneous languages of South Asia");
                            nn890.AddChild("895 Literatures of East and Southeast Asia");
                            nn890.AddChild("896 African literatures");
                            nn890.AddChild("897 Literatures of North American native languages");
                            nn890.AddChild("898 Literatures of South American native languages");
                            nn890.AddChild("899 Literatures of non - Austronesian languages of Oceania, of Austronesian languages, of miscellaneous languages");
                        }
                    }
                    DeweyTreeNode<string> n900 = root.AddChild("900-History & geography");
                    {
                        DeweyTreeNode<string> nn900 = n900.AddChild("900 History");
                        {
                            nn900.AddChild("900 History, geography, & auxiliary disciplines");
                            nn900.AddChild("901 Philosophy & theory of history");
                            nn900.AddChild("902 Miscellany of history");
                            nn900.AddChild("903 Dictionaries, encyclopedias, concordances of history");
                            nn900.AddChild("904 Collected accounts of events");
                            nn900.AddChild("905 Serial publications of history");
                            nn900.AddChild("906 Organizations & management of history");
                            nn900.AddChild("907 Education, research, related topics of history");
                            nn900.AddChild("908 History with respect to groups of people");
                            nn900.AddChild("909 World history");
                        }
                        DeweyTreeNode<string> nn910 = n900.AddChild("910 Geography & travel");
                        {
                            nn910.AddChild("910 Geography & travel");
                            nn910.AddChild("911 Historical geography");
                            nn910.AddChild("912 Graphic representations of surface of earth & of extraterrestrial worlds");
                            nn910.AddChild("913 Geography of & travel in the ancient world");
                            nn910.AddChild("914 Geography of & travel in Europe");
                            nn910.AddChild("915 Geography of & travel in Asia");
                            nn910.AddChild("916 Geography of & travel in Africa");
                            nn910.AddChild("917 Geography of & travel in North America");
                            nn910.AddChild("918 Geography of & travel in South America");
                            nn910.AddChild("919 Geography of & travel in Australasia, Pacific Ocean islands, Atlantic Ocean islands, Arctic islands, Antarctica, & on extraterrestrial worlds");
                        }
                        DeweyTreeNode<string> nn920 = n900.AddChild("920 Biography & genealogy");
                        {
                            nn920.AddChild("920 Biography, genealogy, insignia");
                            nn920.AddChild("929 Genealogy, names, insignia");
                        }
                        DeweyTreeNode<string> nn930 = n900.AddChild("930 History of ancient world");
                        {
                            nn930.AddChild("930 History of ancient world to c. 499");
                            nn930.AddChild("931 China to 420");
                            nn930.AddChild("932 Egypt to 640");
                            nn930.AddChild("933 Palestine to 70");
                            nn930.AddChild("934 South Asia to 647");
                            nn930.AddChild("935 Mesopotamia to 637 and Iranian Plateau to 637");
                            nn930.AddChild("936 Europe north & west of Italian Peninsula to c. 499");
                            nn930.AddChild("937 Italian Peninsula to 476 & adjacent territories to 476");
                            nn930.AddChild("938 Greece to 323");
                            nn930.AddChild("939 Other parts of ancient world");
                        }
                        DeweyTreeNode<string> nn940 = n900.AddChild("940 History of Europe");
                        {
                            nn940.AddChild("940 History of Europe");
                            nn940.AddChild("941 British Isles");
                            nn940.AddChild("942 England & Wales");
                            nn940.AddChild("943 Germany & neighboring central European countries");
                            nn940.AddChild("944 France & Monaco");
                            nn940.AddChild("945 Italy, San Marino, Vatican City, Malta");
                            nn940.AddChild("946 Spain, Andorra, Gibraltar, Portugal");
                            nn940.AddChild("947 Russia & neighboring east European countries");
                            nn940.AddChild("948 Scandinavia");
                            nn940.AddChild("949 Other parts of Europe");
                        }
                        DeweyTreeNode<string> nn950 = n900.AddChild("950 History of Asia");
                        {
                            nn950.AddChild("950 History of Asia");
                            nn950.AddChild("951 China & adjacent areas");
                            nn950.AddChild("952 Japan");
                            nn950.AddChild("953 Arabian Peninsula & adjacent areas");
                            nn950.AddChild("954 India & neighboring south Asian countries");
                            nn950.AddChild("955 Iran");
                            nn950.AddChild("956 Middle East(Near East)");
                            nn950.AddChild("957 Siberia(Asiatic Russia)");
                            nn950.AddChild("958 Central Asia");
                            nn950.AddChild("959 Southeast Asia");
                        }
                        DeweyTreeNode<string> nn960 = n900.AddChild("960 History of Africa");
                        {
                            nn960.AddChild("960 History of Africa");
                            nn960.AddChild("961 Tunisia & Libya");
                            nn960.AddChild("962 Egypt, Sudan, South Sudan");
                            nn960.AddChild("963 Ethiopia & Eritrea");
                            nn960.AddChild("964 Morocco, Ceuta, Melilla Western Sahara, Canary Islands");
                            nn960.AddChild("965 Algeria");
                            nn960.AddChild("966 West Africa & offshore islands");
                            nn960.AddChild("967 Central Africa & offshore islands");
                            nn960.AddChild("968 South Africa & southern Africa");
                            nn960.AddChild("969 South Indian Ocean islands");
                        }
                        DeweyTreeNode<string> nn970 = n900.AddChild("970 History of North America");
                        {
                            nn970.AddChild("970 History of North America");
                            nn970.AddChild("971 Canada");
                            nn970.AddChild("972 Mexico, Central America, West Indies, Bermuda");
                            nn970.AddChild("973 United States");
                            nn970.AddChild("974 Northeastern United States(New England & Middle Atlantic states)");
                            nn970.AddChild("975 Southeastern United States(South Atlantic states)");
                            nn970.AddChild("976 South central United States");
                            nn970.AddChild("977 North central United States");
                            nn970.AddChild("978 Western United States");
                            nn970.AddChild("979 Great Basin & Pacific Slope region of United States");
                        }
                        DeweyTreeNode<string> nn980 = n900.AddChild("980 History of South America");
                        {
                            nn980.AddChild("980 History of South America");
                            nn980.AddChild("981 Brazil");
                            nn980.AddChild("982 Argentina");
                            nn980.AddChild("983 Chile");
                            nn980.AddChild("984 Bolivia");
                            nn980.AddChild("985 Peru");
                            nn980.AddChild("986 Colombia & Ecuador");
                            nn980.AddChild("987 Venezuela");
                            nn980.AddChild("988 Guiana");
                            nn980.AddChild("989 Paraguay & Uruguay");
                        }
                        DeweyTreeNode<string> nn990 = n900.AddChild("990 History of other areas");
                        {
                            nn990.AddChild("990 History of Australasia, Pacific Ocean islands, Atlantic Ocean islands, Arctic islands, Antarctica, extraterrestrial worlds");
                            nn990.AddChild("993 New Zealand");
                            nn990.AddChild("994 Australia");
                            nn990.AddChild("995 New Guinea & neighboring countries of Melanesia");
                            nn990.AddChild("996 Polynesia & other Pacific Ocean islands");
                            nn990.AddChild("997 Atlantic Ocean islands");
                            nn990.AddChild("998 Arctic islands & Antarctica");
                            nn990.AddChild("999 Extraterrestrial worlds");
                        }
                    }
                }
                //returing the tree node root information
            return root;
        }
    }
}
