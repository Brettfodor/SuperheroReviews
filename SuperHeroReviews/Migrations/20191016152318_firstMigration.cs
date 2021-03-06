﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroReviews.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Universe = table.Column<string>(nullable: true),
                    Faction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    UniverseModelID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Heroes_Universes_UniverseModelID",
                        column: x => x.UniverseModelID,
                        principalTable: "Universes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<string>(nullable: true),
                    HeroModelID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reviews_Heroes_HeroModelID",
                        column: x => x.HeroModelID,
                        principalTable: "Heroes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Universes",
                columns: new[] { "ID", "Faction", "Universe" },
                values: new object[] { 1, null, "Marvel" });

            migrationBuilder.InsertData(
                table: "Universes",
                columns: new[] { "ID", "Faction", "Universe" },
                values: new object[] { 2, null, "DC" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "ID", "Content", "Image", "Name", "UniverseModelID" },
                values: new object[,]
                {
                    { 1, "Iron Man is an awesome Hero whose strength is derived from the powers of technology.  Using his enhanced iron suit, he is able to muster super strength, the ability to fly, laser cannons, rockets, and communications with his supercomputer Jarvis", "/images/IronMan.jpg", "IronMan", 1 },
                    { 19, "Although he always exhibited a genius level intellect, young Victor Stone didn’t want a life dedicated to science and research like his parents. Instead, Vic dreamed of being a football player, and devoted all of his time to becoming a star athlete while he was still in high school. But a tragic twist of fate that should have left him dead instead found him becoming part man and part machine—a Cyborg. Saved by his scientist father after an accident left very little of Victor’s body intact, Dr. Silas Stone used all of his advanced scientific knowledge to save his only child’s life, and to rebuild him into a superior being, one that was arguably now more machine than man. As a cyborg, Vic was now far stronger than the average person,  could interface with computers, and emit various types of energy that made him a formidable fighter. Although he ultimately chose the path of the superhero, Victor never fully acclimated to being only partially human. He always carried a sadness within him as he mourns for the normal life he never had. One of the planet’s greatest heroes, Cyborg nevertheless puts all of his internal struggles aside when the time comes to save innocent lives and protect the Earth. Because of his ability to interface with computer systems, perhaps there is no hero more fitting for this modern, digital age.", "/images/VictorStone.jpg", "Cyborg", 2 },
                    { 18, "It’s not easy being green, but Garfield “Gar” Logan certainly makes the best of it. After contracting a rare disease as a child, Gar’s parents were forced to administer an experimental genetic treatment involving the DNA of animals with known resistances to the disease as a potential cure. The good news: their experiment worked. The bad news: it had some pretty dramatic side effects. It turned Gar’s skin, hair and eyes a bright green color and gave him the incredible ability to shapeshift into any animal at will…with just one important caveat. Any form Gar happens to take will also be completely green, no matter what. So much for being able to blend in. Luckily, fading into the background has never been Gar’s goal in life. When he’s not using his powers to be a superhero, he spends his time as an amateur actor and social butterfly, winning friends and “adoring fans” (at least, in his head) wherever he goes. He’s quick with a joke and quicker with a smile, and remains upbeat, optimistic and flirtatious even through the worst of times, making him a valuable asset for the morale of any team he might find himself a part of.", "/images/Beast-Boy.jpg", "Beast Boy", 2 },
                    { 17, "Superman is the ultimate superhero whose only weakness is Kryptonite, fractional piece of his destroyed home planet", "/images/superman.jpg", "Superman", 2 },
                    { 16, "One of the most iconic fictional characters in the world, Batman has dedicated his life to an endless crusade, a war on all criminals in the name of his murdered parents, who were taken from him when he was just a child. Since that tragic night, he has trained his body and mind to near physical perfection to be a self-made Super Hero. He's developed an arsenal of technology that would put most armies to shame. And he's assembled teams of his fellow DC Super Heroes, like the Justice League, the Outsiders and Batman, Incorporated. A playboy billionaire by day, Bruce Wayne’s double life affords him the comfort of a life without financial worry, a loyal butler-turned-guardian and the perfect base of operations in the ancient network of caves beneath his family’s sprawling estate. By night, however, he sheds all pretense, dons his iconic scalloped cape and pointed cowl and takes to the shadowy streets, skies and rooftops of Gotham City.", "/images/batman.jpg", "BatMan", 2 },
                    { 15, "Wonder woman is a former amazon with super strength, and super intelligence", "/images/WonderWoman.jpg", "Wonder Woman", 2 },
                    { 14, "Teenager Kara Zor-el was rocketed to Earth from the dying planet Krypton. Faced with an entire world completely unrecognizable from the one she grew up in, she’s the ultimate new girl in school—with a planet-splitting right hook. A lonely girl with astounding might, she struggles to find her identity on her new reluctant home. As the most powerful teenager on the planet, the Girl of Steel possesses all of Superman’s powers—from superhuman strength, speed, and invulnerability all the way down to his flight and enhanced senses. Still learning to control her awesome powers and lacking her cousin’s self-restraint, she may even be more dangerous than the Man of Steel. Disconnected from a world she’s still struggling to comprehend, she’ll find non-stop action and violence from her first minute on this planet.", "/images/supergirl.jpg", "Supergirl", 2 },
                    { 13, "Monarch of the undersea realm of Atlantis and King of the Seven Seas, Aquaman is one of the most powerful DC Super Heroes—commanding a kingdom that covers three-quarters of the Earth’s surface, including all the creatures contained within. Arthur Curry came from humble beginnings, as most of his life was spent exiled from his home, unaware of his noble origins. When he finally took the throne as an adult, he became the most legendary king in Atlantean history. A founding member of the Justice League of America, Aquaman has fought alongside Superman, Batman and Wonder Woman and held his own against the biggest threats the universe has ever seen. Despite being misunderstood by many as someone who merely “talks to fish,” Aquaman’s super-strength and fighting prowess alone make him a force to be reckoned with. His telepathic abilities make him one of the most powerful minds on the planet. If one chooses to underestimate the sea king, they do so at their own peril.", "/images/AquaMan.jpg", "AquaMan", 2 },
                    { 12, "Alec Holland was an idealistic scientist who was synthesizing a top-secret chemical in his hidden lab in the marshlands. But after a bomb in his office explodes, the young scientist is murdered. Or so it seems. Because rising in his place is the Swamp Thing, a creature made of vegetation that’s absorbed Alec Holland’s memories, personality—and grief. The monstrous Swamp Thing can control every iota of plant life on this planet, from the fungus on stale bread to forests of towering oaks. Superhumanly strong and grotesque, he can grow himself a full array of titanic bodies from even the tiniest sprout of green. A living embodiment of the power and terror in our environment, the Swamp Thing protects both humanity and the environment—usually from each other.", "/images/SwampThing.jpg", "Swamp Thing", 2 },
                    { 20, "When his circus acrobat family was brutally murdered, Dick Grayson was taken in by billionaire and bat-friendly super hero Bruce Wayne. Bruce shared his secret life as Batman with the young boy and eventually molded him into Robin—the Dark Knight’s partner in Gotham. But as Dick grew older, playing second fiddle to the sternest hero in the Justice League began to wear on him, and eventually he struck out on his own, staying true to what he learned as Robin while coming into his own as a respected member of the super hero pantheon. His code, like his mentor’s, is simple—if you’re breaking the law on his turf, watch out. Anyone who doesn’t can expect a short and most assuredly painful trip to Arkham. Yet, while he may share methods and motivation with Batman, Dick knows what being Batman can do. He doesn’t want to become as dark, controlling and lonely as Bruce. But for all the good he’s accomplished while avoiding it, one question is unavoidable—without going as far as Batman, can Nightwing be as effective as he ultimately wants to be?", "/images/NightWing.jpg", "Nightwing", 2 },
                    { 11, "The mysterious power known as the Speed Force is an energy field that has, over the centuries, granted incredible powers of velocity to certain heroes. The most famous of these is the Flash, also known as the Fastest Man Alive. Ever since the days of World War II, there has been a man clad in red who can run at impossible speeds, using his power to save lives and defend those who cannot defend themselves. All between the ticks of a second. In the 1940s, college student Jay Garrick acquired his super-speed abilities in a random lab accident and became the first DC Super Hero to go by the name the Flash. Years later, Jay was succeeded by police scientist Barry Allen, until Barry’s former kid partner Wally West took up the mantle at a time when Barry was considered dead. But, when Barry returned, he became the Flash once again. All three generations of speedsters have been cornerstone members of both the Justice Society and Justice League. The Flash has mastery over not just speed, but time itself, and he has often used his powers to travel though different eras and even into other dimensions. Although the Flash has not always been fast enough to outrun personal tragedy when it has come for him, he always does his best to prevent the same from happening to the people of Central City and Keystone City. In so doing, he's earned himself a spot among the greatest Super Heroes the DC Universe has ever known.", "/images/Flash.jpeg", "Flash", 2 },
                    { 9, "Magneto is ruler of all metal objects and the arch-nemesis of Charles Xavier", "/images/Magneto.jpg", "Magneto", 1 },
                    { 8, "Ant-man has control over the powers of quantum mechanics", "/images/Ant-Man.jpg", "AntMan", 1 },
                    { 7, "Thanos is the most evil villain in the Marvel universe", "/images/Thanos.jpg", "Thanos", 1 },
                    { 6, "Wolverine is an invulnerable x-man that has razor sharp claws", "/images/wolverine.jpg", "Wolverine", 1 },
                    { 5, "Black panther is the king of Wakanda", "/images/BlackPanther.jpg", "Black Panther", 1 },
                    { 4, "Black widow is a super spy.", "/images/black-widow.jpg", "Black Widow", 1 },
                    { 3, "Peter Parker was an orphaned teenage boy who lived in Queens, New York with his Aunt May and Uncle Ben. He was a shy boy, but highly intelligent and excelled in science. He was often teased by other more popular kids like longtime nemesis Flash Thompson, but his life was soon to change on a visit to the science museum.At the science museum, Peter was bitten by a radioactive spider.The spider bite gave Peter spider - like powers with super strength and reflexes.He also had a “spider - sense” alerting him to danger.Armed with these new powers, Peter first sought fame and money before fighting crime.He worked with a wrestling circuit and got some fame and appeared on a television show.During a robbery of the television show, Peter has the chance to stop the thief but chose not to.Spider - Man has supplemented his powers with technology.Being a brilliant chemist and scientist, Peter has made web - slingers, bracelets that shoot out a sticky webbing, allowing him to swing from building to building and ensnare opponents.He has also developed stingers that shoot powerful energy blasts that can stun foes.", "/images/SpiderMan.jpg", "SpiderMan", 1 },
                    { 2, "Thor is the God of Thunder, son of Odin father of all Gods in Norse Mythology.  He has an incredibly powerful hammer that only he has the ability to wield, and mastery over lighting.", "/images/thor.jpg", "Thor", 1 },
                    { 10, "Mystique is a strange creature with blue skin who can take on the appearance of anyone she has seen", "/images/Mystique.jpg", "Mystique", 1 },
                    { 21, "Whether by way of award-winning films like ‘The Dark Knight,’ Emmy-winning animated programs like ‘Batman: The Animated Series,' video game appearances such as the record - breaking ‘Batman: Arkham Asylum,’ or the countless comics stacking comic book shelves and digital libraries, the Joker stands unquestionably as the most recognizable and popular comic book villain in pop culture history.Unpredictable, violent and incredibly dangerous, he is chaos personified and has taken on everyone from his archenemy Batman to even the Man of Steel.But Gotham remains his primary home and Batman his biggest adversary, and no hero is perhaps better suited as in many ways, the Joker is the polar opposite of the Dark Knight.Both were created by a great tragedy, but Batman has since vowed to do whatever it takes to prevent similar incidents, the Joker revels in creating chaos and destroying lives, believing that life’s a big joke and psychotically demonstrating that in a moment, it can all change.Not much is known about his past, but his acts during the present are what define the Joker as one of the greatest threats to our heroes and the people they've sworn to protect. He's killed a Robin, crippled Batgirl, and tortured and murdered countless people throughout the DC Universe—all just for a laugh.", "/images/joker.jpg", "Joker", 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "Content", "HeroModelID", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[,]
                {
                    { 1, "This character is awesome.", 1, 5, "10/10/2019", "Steve" },
                    { 33, "This character is awesome as heck.", 12, 5, "10/10/2019", "Steve" },
                    { 13, "This character is awesome.", 13, 5, "10/10/2019", "Steve" },
                    { 34, "This character is awesome as heck.", 13, 5, "10/10/2019", "Steve" },
                    { 14, "This character is awesome.", 14, 5, "10/10/2019", "Steve" },
                    { 35, "This character is awesome as heck.", 14, 5, "10/10/2019", "Steve" },
                    { 15, "This character is awesome.", 15, 5, "10/10/2019", "Steve" },
                    { 36, "This character is awesome as heck.", 15, 5, "10/10/2019", "Steve" },
                    { 16, "This character is awesome.", 16, 5, "10/10/2019", "Steve" },
                    { 37, "This character is awesome as heck.", 16, 5, "10/10/2019", "Steve" },
                    { 17, "This character is awesome.", 17, 5, "10/10/2019", "Steve" },
                    { 38, "This character is awesome as heck.", 17, 5, "10/10/2019", "Steve" },
                    { 18, "This character is awesome.", 18, 5, "10/10/2019", "Steve" },
                    { 39, "This character is awesome as heck.", 18, 5, "10/10/2019", "Steve" },
                    { 19, "This character is awesome.", 19, 5, "10/10/2019", "Steve" },
                    { 40, "This character is awesome.", 19, 5, "10/10/2019", "Steve" },
                    { 20, "This character is awesome.", 20, 5, "10/10/2019", "Steve" },
                    { 41, "This character is awesome as heck.", 20, 5, "10/10/2019", "Steve" },
                    { 12, "This character is awesome.", 12, 5, "10/10/2019", "Steve" },
                    { 32, "This character is awesome as heck.", 11, 5, "10/10/2019", "Steve" },
                    { 11, "This character is awesome.", 11, 5, "10/10/2019", "Steve" },
                    { 31, "This character is awesome as heck.", 10, 5, "10/10/2019", "Steve" },
                    { 22, "This character is awesome for real.", 1, 5, "10/10/2019", "Steve" },
                    { 2, "This character is awesome.", 2, 5, "10/10/2019", "Steve" },
                    { 23, "This character is awesome for real.", 2, 5, "10/10/2019", "Steve" },
                    { 3, "This character is awesome.", 3, 5, "10/10/2019", "Steve" },
                    { 24, "This character is awesome as heck.", 3, 5, "10/10/2019", "Steve" },
                    { 4, "This character is awesome.", 4, 5, "10/10/2019", "Steve" },
                    { 25, "This character is awesome as heck.", 4, 5, "10/10/2019", "Steve" },
                    { 5, "This character is awesome.", 5, 5, "10/10/2019", "Steve" },
                    { 21, "This character is awesome.", 21, 5, "10/10/2019", "Steve" },
                    { 26, "This character is awesome as heck.", 5, 5, "10/10/2019", "Steve" },
                    { 27, "This character is awesome as heck.", 6, 5, "10/10/2019", "Steve" },
                    { 7, "This character is awesome.", 7, 5, "10/10/2019", "Steve" },
                    { 28, "This character is awesome as heck.", 7, 5, "10/10/2019", "Steve" },
                    { 8, "This character is awesome.", 8, 5, "10/10/2019", "Steve" },
                    { 29, "This character is awesome as heck.", 8, 5, "10/10/2019", "Steve" },
                    { 9, "This character is awesome.", 9, 5, "10/10/2019", "Steve" },
                    { 30, "This character is awesome as heck.", 9, 5, "10/10/2019", "Steve" },
                    { 10, "This character is awesome.", 10, 5, "10/10/2019", "Steve" },
                    { 6, "This character is awesome.", 6, 5, "10/10/2019", "Steve" },
                    { 42, "This character is awesome as heck.", 21, 5, "10/10/2019", "Steve" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_UniverseModelID",
                table: "Heroes",
                column: "UniverseModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HeroModelID",
                table: "Reviews",
                column: "HeroModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Universes");
        }
    }
}
