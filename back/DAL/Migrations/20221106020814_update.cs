using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers");

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 4, "Nisi autem sint incidunt eius molestiae aspernatur at quasi ipsam.", "Dolor atque dolores omnis illum numquam temporibus ipsum voluptatum.", null, 0 },
                    { 5, "Eos vitae eaque unde quo minima.", "Quos ab culpa fugit qui ea maiores earum ea error.", null, 0 },
                    { 6, "Quisquam sit provident facere est maxime vitae consequatur et.", "Id distinctio et repellendus illum consequatur dolor.", null, 0 },
                    { 7, "Ducimus possimus aut cumque esse odio et similique.", "Aspernatur fugit dolor ratione quod consequatur sequi et aspernatur quis.", null, 0 },
                    { 8, "Corrupti reprehenderit ad a sed officiis provident.", "Sed quo aut nisi minima voluptatibus ut cumque.", null, 0 },
                    { 9, "Aut omnis porro ducimus fugit nihil sed omnis dolorem.", "Aut dolor quos ipsa culpa aspernatur quis.", null, 0 },
                    { 10, "Magni laborum distinctio occaecati voluptatem.", "Id quis optio quae laudantium dolorem voluptatem quae qui.", null, 0 },
                    { 11, "Aut aut excepturi dignissimos provident eius reprehenderit iure quis aperiam.", "Aliquid alias magni qui quasi.", null, 0 },
                    { 12, "Omnis consequatur autem corporis nisi alias.", "Incidunt dolore dolor dolores amet.", null, 0 },
                    { 13, "Blanditiis perspiciatis sed quia eligendi id.", "Eum quasi voluptate minus sunt possimus et sit.", null, 0 },
                    { 14, "Velit facere facere aliquid officiis excepturi.", "Molestias ut autem qui ut omnis architecto sequi.", null, 0 },
                    { 15, "Et dolores tenetur rerum in perferendis autem enim sequi.", "Officia non illo nobis amet praesentium et.", null, 0 },
                    { 16, "Rerum non nemo aut dolorem.", "Necessitatibus eos vel perferendis consequatur.", null, 0 },
                    { 17, "Eligendi consequatur cupiditate est rem.", "Tenetur ratione ad aliquid consequatur non.", null, 0 },
                    { 18, "Et qui omnis adipisci deserunt repellat illum.", "Similique culpa dicta aut eos animi inventore recusandae enim.", null, 0 },
                    { 19, "Ducimus nihil labore rerum ipsum ipsum qui earum dicta esse.", "Ut quo similique assumenda illum voluptatem.", null, 0 },
                    { 20, "Fuga et quae omnis praesentium asperiores harum ex.", "Et quia id perferendis dolorem blanditiis.", null, 0 },
                    { 21, "Et adipisci quae necessitatibus error sequi.", "Ut voluptatibus ex eos voluptatibus laborum sint nulla fugiat voluptatem.", null, 0 },
                    { 22, "Praesentium perferendis nemo non aperiam.", "Porro est eius tempora voluptatem eveniet quo deleniti.", null, 0 },
                    { 23, "Voluptas voluptas est aut sequi.", "Soluta ut placeat ea a.", null, 0 },
                    { 24, "Iure excepturi architecto et est qui accusantium laboriosam aliquam quis.", "Sed cum quia laboriosam exercitationem at deserunt occaecati asperiores non.", null, 0 },
                    { 25, "Qui qui quaerat officiis tempora non officiis optio quis sunt.", "Doloribus sequi et numquam voluptas doloribus qui qui facilis ex.", null, 0 },
                    { 26, "Et omnis illum aut nam vel repudiandae labore.", "Repudiandae sunt temporibus deleniti nesciunt aliquam sit ad animi.", null, 0 },
                    { 27, "Quibusdam qui non voluptates minus culpa ut adipisci et vero.", "Temporibus architecto vero occaecati ea eos.", null, 0 },
                    { 28, "Veritatis perspiciatis odio placeat omnis repellendus cupiditate voluptas.", "Et ea omnis consequuntur perspiciatis delectus libero dolorem.", null, 0 },
                    { 29, "Sint nobis error corrupti non vel tempore sit ea.", "Ut sint optio harum sed labore aperiam quaerat.", null, 0 },
                    { 30, "Fugit adipisci officiis ipsum id laudantium voluptas qui.", "Illum sed et officia voluptas aliquid magnam illum est.", null, 0 },
                    { 31, "Et consequatur hic cum sequi nihil libero iste dolor incidunt.", "Nostrum numquam facilis nobis quia.", null, 0 },
                    { 32, "Sint ea qui eius illo.", "At officiis vel vero et adipisci.", null, 0 },
                    { 33, "Excepturi commodi blanditiis recusandae quo.", "Iste et et nemo impedit amet blanditiis doloremque aut quia.", null, 0 },
                    { 34, "Vero vel corporis debitis perspiciatis sed et.", "Sed exercitationem saepe a fuga maxime enim nulla.", null, 0 },
                    { 35, "Nihil adipisci et mollitia omnis consequatur optio impedit omnis dolorem.", "Perspiciatis delectus aliquid voluptas aut.", null, 0 },
                    { 36, "Assumenda exercitationem dolorem suscipit dolorum omnis libero.", "Quo nihil ea et voluptatem.", null, 0 },
                    { 37, "Aut aut eos sunt commodi ipsam.", "Excepturi ab earum quo eos omnis.", null, 0 },
                    { 38, "Aspernatur voluptatem voluptatem provident aspernatur ipsa ipsa.", "Laudantium possimus velit qui aut.", null, 0 },
                    { 39, "Consequatur sed neque adipisci voluptatem cum ex.", "Aut non aut dolorem quia odio nulla et.", null, 0 },
                    { 40, "Aspernatur perferendis ut accusantium et similique.", "Cupiditate repellendus consequatur consequuntur aspernatur vel eos.", null, 0 },
                    { 41, "Rerum perspiciatis adipisci cumque sequi voluptas est ut.", "Porro omnis optio ex sed error.", null, 0 },
                    { 42, "Voluptates voluptatem eos sapiente eos repellat aut.", "Ducimus quaerat vitae qui doloremque et velit consequatur et numquam.", null, 0 },
                    { 43, "Molestiae incidunt consequuntur et cumque provident eos error veritatis animi.", "Omnis distinctio enim cum consequatur asperiores delectus.", null, 0 },
                    { 44, "Praesentium quia velit architecto nam.", "Qui ad quia nihil ea sint.", null, 0 },
                    { 45, "Expedita est rerum corrupti debitis et dolorem ratione repellat.", "Qui odit eum praesentium adipisci tempore eum.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 46, "Est consequatur dolorum deserunt delectus et accusamus voluptatem aspernatur.", "Tempora vel architecto neque dolores tempora voluptas reprehenderit.", null, 0 },
                    { 47, "A natus minima aperiam laborum ut eligendi minima.", "Quidem enim porro animi veniam earum quae nihil.", null, 0 },
                    { 48, "Velit sed omnis deleniti fuga quia ab voluptas non in.", "Est et quo minus possimus rem.", null, 0 },
                    { 49, "Laboriosam accusamus ut quam aut consequuntur enim maiores qui deleniti.", "Doloribus enim omnis beatae rerum facilis.", null, 0 },
                    { 50, "Dignissimos hic officia reiciendis quia labore sint qui et perferendis.", "Sint sint atque aliquid in laboriosam.", null, 0 },
                    { 51, "Dolores tenetur qui itaque quia.", "Ea est perspiciatis quaerat blanditiis ut.", null, 0 },
                    { 52, "Quia qui voluptatum quam consequuntur.", "Possimus est maxime id et.", null, 0 },
                    { 53, "Dolorem laborum reiciendis rem rerum quidem mollitia aut.", "Ut odio iste quidem et delectus iure ut.", null, 0 },
                    { 54, "Corrupti voluptas voluptas veritatis vitae.", "Cum dolor omnis sint et voluptatum.", null, 0 },
                    { 55, "Et et iste tempore magnam.", "Aut voluptatibus similique perferendis nulla labore quasi sed earum.", null, 0 },
                    { 56, "Provident perspiciatis ut suscipit quae.", "Reprehenderit et dolor tempore omnis aut beatae eius voluptas.", null, 0 },
                    { 57, "Mollitia recusandae quos possimus consequatur nihil consectetur.", "Cum est et eius consequatur consequatur quia fuga unde eveniet.", null, 0 },
                    { 58, "Non modi repudiandae porro est sit delectus.", "In architecto fuga mollitia vero rem dolor hic dolores rerum.", null, 0 },
                    { 59, "Eum fuga dolorem nihil tempore optio iusto.", "Perferendis voluptatibus rerum eius magni esse provident cum ut.", null, 0 },
                    { 60, "Ducimus neque quis alias quae est et.", "Ut aut sint est optio rerum eveniet ratione asperiores.", null, 0 },
                    { 61, "Pariatur fugit sapiente eum est voluptas et placeat.", "Omnis rerum itaque ad modi cum.", null, 0 },
                    { 62, "Neque esse optio quae maiores totam.", "Dolor est animi placeat totam dolores tenetur ut.", null, 0 },
                    { 63, "Ipsa distinctio natus error quidem eum earum velit rerum error.", "Id perspiciatis qui cumque mollitia numquam iure omnis quis.", null, 0 },
                    { 64, "Odio aliquid amet tempore qui excepturi est quos accusamus.", "Tenetur optio nihil qui deserunt.", null, 0 },
                    { 65, "Similique velit molestiae nobis et iste ut aut sit.", "Consequatur iusto voluptate cumque vel voluptatem dolorum.", null, 0 },
                    { 66, "Quia quam quam quas expedita neque dolores alias.", "Quia nostrum aut in quia facere in molestiae necessitatibus.", null, 0 },
                    { 67, "Impedit explicabo sed sed eum distinctio veritatis amet deleniti veniam.", "Laborum quas dignissimos consequuntur corrupti id qui ut.", null, 0 },
                    { 68, "Cupiditate et temporibus impedit quas maiores soluta et cumque.", "Dolorem est adipisci et ullam.", null, 0 },
                    { 69, "Perferendis doloremque ab assumenda sequi harum inventore voluptatem.", "Voluptate molestias et sint nemo.", null, 0 },
                    { 70, "Repudiandae expedita praesentium est et eveniet cum et itaque est.", "Exercitationem amet velit vel harum dolor minus.", null, 0 },
                    { 71, "Dignissimos neque quisquam quia optio quas in facilis aut ad.", "Laboriosam et delectus nisi placeat magnam non deserunt.", null, 0 },
                    { 72, "Voluptatem veritatis quisquam minima id quas unde vero.", "Unde ut sint est ullam et et.", null, 0 },
                    { 73, "Pariatur et qui saepe impedit officia nesciunt facere porro autem.", "Quidem voluptatem dolore consequatur ut enim omnis veritatis magnam voluptatem.", null, 0 },
                    { 74, "Iure accusamus nihil aut totam iusto.", "Distinctio quidem natus quibusdam nihil excepturi possimus.", null, 0 },
                    { 75, "Asperiores voluptatem veritatis illo nemo alias quis molestias molestiae alias.", "Dolorem et nihil voluptas voluptas exercitationem ullam qui.", null, 0 },
                    { 76, "Magni et fuga perferendis consectetur qui quibusdam debitis maiores dolore.", "Quia et natus harum quia ea.", null, 0 },
                    { 77, "Quia velit molestias rerum sint ut laboriosam voluptate.", "A voluptas aliquid iusto delectus deleniti.", null, 0 },
                    { 78, "Ex ducimus ut ut iste est hic in.", "Aut est voluptates deleniti aut eos eum nihil nostrum.", null, 0 },
                    { 79, "Harum officiis inventore a et dicta perferendis.", "Omnis natus illo deserunt nam expedita consectetur possimus.", null, 0 },
                    { 80, "Nesciunt commodi culpa et voluptates aliquam.", "Dolor necessitatibus eum praesentium esse nihil est.", null, 0 },
                    { 81, "Voluptatum molestiae eos voluptatem cum quibusdam fuga quis officia nihil.", "Ratione optio ipsum dolorum molestiae consequatur ut quidem.", null, 0 },
                    { 82, "Vero aliquid nemo culpa doloremque.", "Quia in voluptas nemo natus sit vitae.", null, 0 },
                    { 83, "Rerum consequatur occaecati quibusdam non quod et ipsum ea dolore.", "Non beatae voluptate sequi est qui.", null, 0 },
                    { 84, "Nulla quas sunt adipisci itaque occaecati pariatur rerum dolorum ut.", "Placeat temporibus tempore dolor sed quas quia ab.", null, 0 },
                    { 85, "Consectetur modi nulla mollitia laborum quo aliquam deserunt omnis.", "Et et rerum minima veniam pariatur.", null, 0 },
                    { 86, "Vel molestiae quia ut impedit sequi odio dolor placeat.", "Et eaque ab deleniti ex explicabo.", null, 0 },
                    { 87, "Voluptate atque nam quaerat vel ut enim quo culpa fugiat.", "Doloremque id maiores consequuntur at nihil.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 88, "Quis rem voluptatem rerum quibusdam soluta corrupti sit inventore.", "Blanditiis nulla earum et non dolores.", null, 0 },
                    { 89, "Qui adipisci sed corrupti odit natus.", "Id rem sit nam in.", null, 0 },
                    { 90, "Aliquid non tempora nam soluta rerum illo sit.", "Id unde vitae ullam mollitia ducimus accusamus.", null, 0 },
                    { 91, "Minima quis soluta suscipit illo voluptatem.", "Est at quas unde culpa rem.", null, 0 },
                    { 92, "Nemo qui amet nihil dignissimos velit et mollitia.", "Odio necessitatibus velit exercitationem ex delectus sed unde qui in.", null, 0 },
                    { 93, "Vero eligendi voluptatum earum sit officia ut maxime rerum et.", "Eveniet iure quam est reiciendis ut voluptates sequi rerum tenetur.", null, 0 },
                    { 94, "Non similique nisi rerum quasi ea dolor.", "Saepe molestias expedita molestias itaque.", null, 0 },
                    { 95, "Quia vel consequatur corrupti ipsum velit natus ut.", "Voluptatem velit quibusdam voluptatem ex placeat aliquid minus et iusto.", null, 0 },
                    { 96, "Quas consequatur praesentium nihil dolor quis repudiandae delectus et.", "Dicta itaque debitis facere ratione et.", null, 0 },
                    { 97, "Molestias omnis qui laudantium ea in laudantium voluptas.", "Eaque et blanditiis beatae sed.", null, 0 },
                    { 98, "Sunt incidunt iste saepe alias ullam fuga reprehenderit.", "Aliquid sed accusamus qui non et nisi.", null, 0 },
                    { 99, "Dolor rerum sit est officiis ratione voluptatibus ipsa.", "Ab minus iure non dolores qui aspernatur.", null, 0 },
                    { 100, "Aut neque sint eaque dignissimos non cum molestiae.", "Esse ad quis corrupti quae aspernatur esse cumque corrupti.", null, 0 },
                    { 101, "Beatae corrupti officia esse aut temporibus.", "Veritatis qui et nobis dicta doloribus exercitationem.", null, 0 },
                    { 102, "Nostrum voluptas mollitia omnis quibusdam quos rerum.", "Sed magnam ut accusantium repellat voluptates tempore.", null, 0 },
                    { 103, "Quaerat assumenda similique enim rem eum.", "Quod sed quaerat quod cum.", null, 0 },
                    { 104, "Sapiente voluptatem consequatur suscipit qui et nemo ducimus minima.", "Et rem doloremque inventore et porro.", null, 0 },
                    { 105, "Reprehenderit expedita quas sit animi maiores laborum.", "Qui quis ab deleniti eligendi possimus repellat facere et enim.", null, 0 },
                    { 106, "Adipisci alias eos dicta rerum reiciendis non eum dignissimos.", "Et ut optio qui sunt sint.", null, 0 },
                    { 107, "Aut et voluptas incidunt reiciendis omnis enim iusto dicta mollitia.", "Laudantium quis et alias est fugiat quibusdam recusandae sed est.", null, 0 },
                    { 108, "Libero consectetur doloremque voluptatem velit autem.", "Ut aperiam laboriosam qui delectus at sequi.", null, 0 },
                    { 109, "Consequatur quia fugiat minima adipisci vero quia distinctio.", "Soluta voluptatibus reprehenderit doloremque deleniti eum ipsam necessitatibus.", null, 0 },
                    { 110, "Rem illum autem veniam quos et debitis tenetur vel.", "Non veniam quod nihil ratione voluptas enim.", null, 0 },
                    { 111, "Expedita eaque vel tenetur quo et sit perspiciatis non dolorem.", "Quaerat eos maiores hic soluta soluta neque quibusdam.", null, 0 },
                    { 112, "Sint consectetur eius qui quibusdam in temporibus porro repellendus neque.", "Quos est fugiat explicabo alias molestias eum.", null, 0 },
                    { 113, "Exercitationem libero consectetur doloremque eaque assumenda.", "Dignissimos a aut qui doloremque mollitia nihil itaque nulla quidem.", null, 0 },
                    { 114, "Architecto velit ut ratione est tempore ut velit animi expedita.", "Illo earum aperiam nobis minima consequatur saepe rem rerum.", null, 0 },
                    { 115, "Consectetur itaque quis laboriosam ut ab veritatis et et maiores.", "Est amet molestias quia qui.", null, 0 },
                    { 116, "Harum omnis et veniam dicta est earum enim.", "Voluptatem voluptatem non esse amet voluptate nihil nesciunt.", null, 0 },
                    { 117, "Illum aut vero vel voluptas.", "Vitae amet voluptatem hic beatae sint blanditiis et.", null, 0 },
                    { 118, "Quas occaecati aliquam libero fugiat.", "Quo ab enim voluptatibus repellat facere eligendi.", null, 0 },
                    { 119, "Qui consequatur placeat non sed.", "Maiores quo a quam dicta delectus odit.", null, 0 },
                    { 120, "Ipsum iure ducimus veniam non.", "Id officia illo itaque voluptas molestias voluptas rem deserunt consectetur.", null, 0 },
                    { 121, "Totam ut et rerum odio id nobis provident.", "Sunt autem asperiores deleniti dolorem.", null, 0 },
                    { 122, "Rerum cum fugiat repudiandae recusandae nemo dolor dolor laborum.", "Veniam corporis temporibus et esse soluta.", null, 0 },
                    { 123, "Qui aliquid pariatur quia itaque omnis consectetur dolores.", "Praesentium et aut expedita aut numquam qui labore.", null, 0 },
                    { 124, "Repellendus qui vitae earum nulla.", "Consectetur eos ut deleniti consequatur.", null, 0 },
                    { 125, "Aspernatur aperiam et et cum laudantium.", "Corporis quo quis voluptatem accusamus rem dolorem.", null, 0 },
                    { 126, "Rem iste doloribus voluptatem quia nesciunt vel officia dolorem.", "Blanditiis voluptas consequatur debitis odit laudantium qui iusto.", null, 0 },
                    { 127, "Reprehenderit atque voluptatem optio aut aut eos nihil.", "Laborum voluptatem et provident aut.", null, 0 },
                    { 128, "Omnis quos iste quam est ut.", "Laudantium at aut ab sed occaecati.", null, 0 },
                    { 129, "Eveniet molestiae sint ipsa ut omnis.", "Doloremque quia a et in ut ut et placeat saepe.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 130, "Maxime qui eveniet aut cumque voluptatem sit eveniet.", "Impedit quia quisquam molestiae fugiat.", null, 0 },
                    { 131, "Esse voluptatibus voluptatem et dolores.", "Ipsa dignissimos necessitatibus ut maxime nam sapiente eos ipsam libero.", null, 0 },
                    { 132, "Fugit pariatur quisquam repudiandae quis quisquam.", "Aut dolor placeat sit cumque ut.", null, 0 },
                    { 133, "Voluptatum iure quia placeat aut dolorum asperiores ea.", "Aliquam corporis optio nostrum minus molestias odio aut ut vitae.", null, 0 },
                    { 134, "Et est exercitationem maiores qui.", "Repellendus sunt et deserunt ipsam.", null, 0 },
                    { 135, "Corporis vitae aperiam ipsa omnis totam.", "Quis culpa ut facilis excepturi ut.", null, 0 },
                    { 136, "Facilis non placeat omnis officia amet perferendis.", "Facere saepe sapiente rerum voluptatem quae est ratione.", null, 0 },
                    { 137, "Earum omnis sit pariatur et rem.", "Labore et impedit et beatae id nostrum.", null, 0 },
                    { 138, "Quas eos est optio quae adipisci nesciunt dolorem et officia.", "Incidunt sed vitae doloremque ullam doloribus eligendi.", null, 0 },
                    { 139, "Illo quia doloribus error consequatur quos labore tenetur laboriosam.", "Amet voluptas quo quod deleniti.", null, 0 },
                    { 140, "Praesentium culpa ullam qui numquam hic accusantium est.", "Alias sit eum est molestiae ratione dolorem error enim sunt.", null, 0 },
                    { 141, "Ex similique maxime sunt at similique.", "Laudantium est eos dolorum aut expedita.", null, 0 },
                    { 142, "Eos occaecati assumenda pariatur unde perspiciatis inventore et pariatur.", "Quisquam laboriosam esse delectus maiores doloremque.", null, 0 },
                    { 143, "Corporis maiores et porro libero dolores.", "Numquam dolores voluptatem dolorem unde cupiditate dolores.", null, 0 },
                    { 144, "Perferendis quam quia debitis qui sint.", "Officia est libero doloremque incidunt ut cumque veniam qui aperiam.", null, 0 },
                    { 145, "Odio vel aut voluptatem natus.", "Eaque sint tempora nisi animi veritatis qui deserunt.", null, 0 },
                    { 146, "Est earum quos aut ut et et nulla est.", "Perferendis minima molestiae est est voluptatem.", null, 0 },
                    { 147, "In amet molestiae quaerat eligendi est modi totam et libero.", "Quia placeat ex excepturi dolores nobis.", null, 0 },
                    { 148, "Ut itaque odit est quae fuga sed possimus.", "Minima eaque iusto ullam et aliquam eaque rerum.", null, 0 },
                    { 149, "Ut architecto corrupti quia tempora sunt vel.", "Illo sit et autem sit porro.", null, 0 },
                    { 150, "Omnis quod quo iusto dolores dolor commodi unde soluta eum.", "Quod provident quos est qui.", null, 0 },
                    { 151, "Doloremque fugit et nobis incidunt voluptatem esse.", "Maiores doloribus et temporibus eos nulla corporis qui quia suscipit.", null, 0 },
                    { 152, "Consequatur ratione molestiae velit et non.", "Cum quae corrupti enim sed esse vero dolorem.", null, 0 },
                    { 153, "Iusto sit iste et et.", "Et voluptatum neque harum illum voluptatibus nam expedita eos perferendis.", null, 0 },
                    { 154, "Et molestiae porro consequatur officiis ipsa magni iure.", "Voluptate aut et ipsa sunt et non temporibus quae.", null, 0 },
                    { 155, "Molestiae molestiae dolorem illo amet molestiae blanditiis eius dignissimos.", "Et commodi necessitatibus iusto eligendi ratione nemo et ut.", null, 0 },
                    { 156, "Iure voluptatem eaque et quis officia dolore quia sunt fugit.", "Blanditiis quidem molestias et odio laudantium sit omnis sit.", null, 0 },
                    { 157, "Dolorem blanditiis sed molestias nihil alias aliquid.", "Reprehenderit optio repellat quae perferendis qui consectetur laboriosam.", null, 0 },
                    { 158, "Facere quasi ea explicabo amet non ut cum.", "Incidunt qui quia iure et velit.", null, 0 },
                    { 159, "Ut modi et cum nam illum sed incidunt iste.", "Impedit aperiam officiis et maiores ut voluptate est ut.", null, 0 },
                    { 160, "Repellat rem quaerat dignissimos dolorem earum inventore quo nemo at.", "Nulla quidem corporis ipsum sed qui corrupti eaque corporis.", null, 0 },
                    { 161, "Et maiores sunt aut quo vero fugiat.", "Voluptatibus quis placeat quae consequatur.", null, 0 },
                    { 162, "Laborum quo sapiente atque ipsum veniam rerum voluptas tenetur.", "Accusantium et veritatis quia soluta.", null, 0 },
                    { 163, "Architecto consequatur sapiente est quia tempore dolorem aut sapiente.", "Beatae reprehenderit maiores et dolorum et corrupti illo quae voluptas.", null, 0 },
                    { 164, "Itaque laboriosam ab eaque quos.", "Perspiciatis sit dolor necessitatibus eum aut vel.", null, 0 },
                    { 165, "Optio et similique sunt exercitationem.", "Et amet voluptatem voluptatum ex itaque in.", null, 0 },
                    { 166, "Placeat asperiores id error dolorum unde.", "Mollitia sunt qui facere eligendi omnis dolorem veritatis.", null, 0 },
                    { 167, "Et illum sit numquam dicta.", "Ducimus maiores cupiditate libero perspiciatis laborum.", null, 0 },
                    { 168, "Delectus aut pariatur ratione minus veniam.", "Facere quos aut aut aut totam et ipsum.", null, 0 },
                    { 169, "Architecto consectetur voluptatum nesciunt voluptatem repellat.", "Tempore quia dignissimos dignissimos fuga dolor qui aut rerum voluptatem.", null, 0 },
                    { 170, "Soluta molestiae ut eum et.", "Dolor nemo dicta sunt praesentium rem rem ipsam veniam facilis.", null, 0 },
                    { 171, "Nam aut voluptas est distinctio aspernatur aut molestiae fugiat eos.", "Aut est ut aut totam veritatis reiciendis quasi.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 172, "Ea est facere enim placeat dignissimos voluptatem unde sunt.", "Accusantium ut molestiae sit quo maiores et.", null, 0 },
                    { 173, "Qui itaque ea provident voluptatem aperiam.", "Doloribus provident voluptates dolor quod voluptatem molestiae est dolores repudiandae.", null, 0 },
                    { 174, "Saepe consequuntur id sapiente libero tempore.", "Dolorum facilis est ea saepe.", null, 0 },
                    { 175, "Nihil dolore culpa explicabo blanditiis earum.", "Sunt nesciunt amet architecto recusandae dolorum.", null, 0 },
                    { 176, "Amet rerum eius fuga ducimus fuga omnis ad laborum.", "Est eos autem doloribus vitae fugiat nobis.", null, 0 },
                    { 177, "Aperiam dolor doloremque eos autem magni.", "Id qui at velit nemo magnam.", null, 0 },
                    { 178, "Temporibus reprehenderit voluptatibus quia veritatis deserunt veniam laborum voluptas modi.", "Laborum illo dolor et et culpa distinctio magni unde.", null, 0 },
                    { 179, "Esse in minus molestiae doloremque et ratione odio.", "Est ut animi natus optio.", null, 0 },
                    { 180, "Est atque porro eius dolores omnis numquam.", "Vel ut itaque et ut.", null, 0 },
                    { 181, "Amet quia qui et natus.", "Dolorem voluptate et eum earum.", null, 0 },
                    { 182, "Qui ut porro labore et dolorum earum eum unde sed.", "Natus neque autem velit hic et accusantium ipsa quibusdam rem.", null, 0 },
                    { 183, "Ut totam quos et dolorum dolores nihil alias.", "Accusantium enim libero delectus odio amet.", null, 0 },
                    { 184, "Ducimus aperiam nam non vel doloribus.", "Quae officiis maiores sit et et ut.", null, 0 },
                    { 185, "Reiciendis et sunt vel neque et velit corrupti.", "Rerum enim soluta et deserunt voluptates cumque.", null, 0 },
                    { 186, "Id sed et et aut.", "Sed voluptatibus ut minima iure eos illum aut ab.", null, 0 },
                    { 187, "Dolorum commodi animi id quis illo et aspernatur id ut.", "Sed molestiae provident praesentium sit optio.", null, 0 },
                    { 188, "Ut omnis rerum ullam iure a odio modi.", "Autem neque ut mollitia voluptas ut.", null, 0 },
                    { 189, "Optio quidem dolor esse aut cupiditate nihil.", "Ipsum non eos qui ab ut ducimus.", null, 0 },
                    { 190, "Quaerat nulla harum et voluptas eum eligendi nisi corrupti quis.", "Illum quibusdam exercitationem est mollitia harum in mollitia.", null, 0 },
                    { 191, "Odio non dignissimos voluptatibus ut magnam veniam.", "Aut optio nobis ut quidem nam voluptatem itaque non.", null, 0 },
                    { 192, "Et aut ipsum mollitia deleniti quidem sunt eos placeat a.", "Voluptatibus natus pariatur et et doloremque recusandae quo rerum.", null, 0 },
                    { 193, "Nulla nam totam maiores cupiditate molestias quo exercitationem.", "Corrupti omnis aut impedit molestiae optio.", null, 0 },
                    { 194, "Odio voluptates dolorum hic eligendi dolores.", "Consequatur fuga repudiandae velit commodi occaecati.", null, 0 },
                    { 195, "Sint debitis ex et et aut omnis repellat rerum.", "Blanditiis omnis occaecati necessitatibus quo aspernatur nulla dolorem possimus rerum.", null, 0 },
                    { 196, "Nihil eos ullam ut maxime quia nihil quidem occaecati voluptas.", "Corrupti amet laudantium nobis et.", null, 0 },
                    { 197, "Suscipit ut ut dignissimos nesciunt commodi ea cumque ratione maiores.", "Vel vel voluptatem vel expedita optio.", null, 0 },
                    { 198, "Vitae cupiditate facilis tempora quisquam molestias ut rerum eos quos.", "Qui alias necessitatibus doloremque iusto.", null, 0 },
                    { 199, "Consequatur alias et quaerat rerum qui quia.", "Eum quisquam omnis omnis occaecati ex totam voluptates cum.", null, 0 },
                    { 200, "Repudiandae perferendis recusandae et voluptas vel.", "Quia qui in sed aliquam aut distinctio.", null, 0 },
                    { 201, "Cupiditate ut similique voluptatem voluptates beatae.", "Voluptatem nam dolorem quod veritatis.", null, 0 },
                    { 202, "Assumenda qui voluptatibus dolore cum natus.", "Non quis sit rerum tempore maiores numquam inventore sint libero.", null, 0 },
                    { 203, "Maxime magnam sed corrupti veritatis et aut.", "Nobis quas veniam sequi pariatur est fugiat aut aut.", null, 0 },
                    { 204, "Ducimus dolorem impedit voluptas molestias.", "Quisquam possimus voluptas similique perferendis architecto et.", null, 0 },
                    { 205, "Ut eligendi ea tenetur exercitationem.", "Quos omnis sit praesentium nihil aperiam.", null, 0 },
                    { 206, "Adipisci consequuntur perspiciatis earum sed et.", "Molestiae sapiente ducimus omnis ut odit reprehenderit.", null, 0 },
                    { 207, "Error cupiditate et aliquam esse et.", "Dolore ea inventore natus tempore aut ducimus voluptatum iusto nam.", null, 0 },
                    { 208, "Dignissimos atque tenetur illo sit officiis placeat dolorum fugiat nostrum.", "Id dolorem soluta aut earum perspiciatis voluptate.", null, 0 },
                    { 209, "Nam natus perspiciatis ab numquam exercitationem deleniti.", "Ipsum itaque porro harum velit quia non quasi ea.", null, 0 },
                    { 210, "Similique veniam eos qui omnis.", "Velit soluta quam qui hic.", null, 0 },
                    { 211, "Recusandae dolorem facilis aut et fugiat qui veniam et odio.", "Eos enim voluptatibus itaque sed ex veniam blanditiis at.", null, 0 },
                    { 212, "Et repellendus unde vel maiores voluptatem tempore blanditiis consectetur quasi.", "Maxime voluptatem sit quasi ex adipisci sint iure quisquam.", null, 0 },
                    { 213, "Porro quasi qui aliquam ducimus non laborum.", "Sunt non similique nostrum eum et.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 214, "Est dolorum quis sunt quidem odit deleniti.", "Dolores animi et non aut laboriosam molestias nisi.", null, 0 },
                    { 215, "Praesentium voluptas molestiae provident adipisci impedit.", "Veritatis minima odit eveniet in rerum aut.", null, 0 },
                    { 216, "Vel molestiae vel adipisci assumenda consequatur commodi cumque aliquam hic.", "Quisquam et et non omnis.", null, 0 },
                    { 217, "Aut quod sequi autem et et fugit dolores placeat maiores.", "Ab ad saepe accusantium velit dolore et ut quo reiciendis.", null, 0 },
                    { 218, "Dolor non ut ea ex quibusdam distinctio officia inventore quia.", "Quod nam molestiae consequatur officia velit quos.", null, 0 },
                    { 219, "Itaque assumenda beatae voluptas aspernatur sunt qui sit.", "Corporis alias laborum exercitationem autem similique sit molestiae.", null, 0 },
                    { 220, "Suscipit recusandae corporis similique voluptatem qui nesciunt animi non nisi.", "Totam exercitationem et et sunt fuga est dolore nihil qui.", null, 0 },
                    { 221, "Culpa tempore nulla sint et molestiae totam nam.", "Voluptas laudantium aut doloribus sit ut aperiam architecto.", null, 0 },
                    { 222, "Dolorum commodi distinctio minima sunt ratione consequuntur magnam vitae.", "Voluptas aliquid modi omnis aliquam deserunt voluptatem ipsum magni sint.", null, 0 },
                    { 223, "Nemo quis quas enim eum quis perferendis quod similique.", "Facilis non atque iure consectetur.", null, 0 },
                    { 224, "Doloribus sed numquam ut libero omnis deserunt veniam.", "Voluptatem adipisci voluptates neque ea impedit impedit nemo sint rerum.", null, 0 },
                    { 225, "Cumque non nam rerum quasi ut quis aliquam reprehenderit perspiciatis.", "Veritatis officia quaerat suscipit voluptatibus.", null, 0 },
                    { 226, "Eos officiis omnis non commodi perferendis.", "Consequatur eos est vitae consequatur voluptatem magni qui vel.", null, 0 },
                    { 227, "Nostrum autem dignissimos voluptatem quia ullam ut adipisci aut.", "Aut necessitatibus et aliquam animi dolorem.", null, 0 },
                    { 228, "Tenetur dolorem et est maxime et sapiente.", "Magnam quos commodi eum alias et quam explicabo nesciunt.", null, 0 },
                    { 229, "Sed molestias ut eius in incidunt dicta.", "Quod eos error in sint eos quia magnam.", null, 0 },
                    { 230, "Numquam dolore non officia sed.", "Excepturi consequuntur beatae ipsa consectetur ea quidem consequatur.", null, 0 },
                    { 231, "Enim esse voluptas id illo repellat minima est fugiat unde.", "Autem consectetur quas vitae omnis consequatur porro quos.", null, 0 },
                    { 232, "Voluptate officiis sunt ut provident sunt voluptatibus sunt.", "Voluptas reiciendis rerum est maxime.", null, 0 },
                    { 233, "Voluptatem laudantium vitae animi est ut quas est molestiae non.", "Consequatur voluptas velit dolorem nam similique voluptatum.", null, 0 },
                    { 234, "Architecto assumenda iusto at totam et corporis expedita.", "Tempore dolorum atque enim unde tenetur quibusdam quae.", null, 0 },
                    { 235, "Nam molestiae consequuntur alias ut qui dolorem ad sunt aut.", "Molestias et nulla labore ratione mollitia.", null, 0 },
                    { 236, "Veritatis dolor et maxime non fuga perspiciatis.", "Ut eveniet in consequuntur et illo omnis minima quaerat.", null, 0 },
                    { 237, "Rem dolorem in sequi suscipit suscipit sed est est.", "Praesentium in id expedita dolor et possimus qui.", null, 0 },
                    { 238, "Soluta voluptates dolores est sed sint provident accusamus.", "Placeat assumenda dolorem tenetur cum.", null, 0 },
                    { 239, "Voluptas perspiciatis aliquid dolores illum error laudantium.", "Voluptatem animi praesentium quos enim quis expedita facilis.", null, 0 },
                    { 240, "Similique fuga cumque adipisci earum cumque ut explicabo deserunt culpa.", "Nemo numquam rerum adipisci eum et.", null, 0 },
                    { 241, "Laborum nobis sapiente cupiditate velit aut optio quia tenetur.", "Corporis omnis eum nesciunt dignissimos quidem recusandae non nemo debitis.", null, 0 },
                    { 242, "Sint magni eum nesciunt ab explicabo a minima non ut.", "Enim in et labore modi.", null, 0 },
                    { 243, "Id enim et nobis laboriosam porro sit saepe excepturi.", "Omnis cum quibusdam dolorem qui.", null, 0 },
                    { 244, "Tenetur omnis voluptates aspernatur velit.", "Facilis tenetur sequi quia odit accusamus beatae voluptas voluptas quos.", null, 0 },
                    { 245, "Dolor voluptas nulla earum vitae consequatur sunt.", "Animi delectus rerum voluptas aspernatur fuga quia dolorem eum.", null, 0 },
                    { 246, "At veritatis eveniet vel ipsa provident nam.", "Nesciunt aut dolores molestiae quia et est maxime.", null, 0 },
                    { 247, "Aliquid commodi velit eum libero cumque.", "Aliquid sit nam temporibus sed tempore.", null, 0 },
                    { 248, "Incidunt voluptatem sit commodi quia quo modi ut dolorum est.", "Molestias eligendi velit vitae rem nostrum reprehenderit enim.", null, 0 },
                    { 249, "Incidunt ut accusantium qui suscipit porro.", "Ut exercitationem et voluptas nesciunt ducimus officia illo vel.", null, 0 },
                    { 250, "Nulla vitae minima exercitationem hic et quam autem.", "Sit voluptatum harum voluptates ut.", null, 0 },
                    { 251, "Enim commodi provident quae consequatur neque.", "Numquam et officiis totam modi reiciendis.", null, 0 },
                    { 252, "Similique neque perferendis et tenetur magni illum accusantium tempora qui.", "Error et expedita ut ut doloribus aut officia ut dolores.", null, 0 },
                    { 253, "Recusandae impedit at et error quas temporibus a sed.", "Inventore aspernatur quam cumque rerum libero.", null, 0 },
                    { 254, "Consequatur quo quasi iure tenetur maxime accusantium.", "Libero tempore architecto corporis officiis accusamus repellendus et ipsum.", null, 0 },
                    { 255, "Vel et saepe aut accusantium velit beatae.", "Dolore voluptatibus dolor cumque ut aspernatur.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 256, "Nostrum iure illo pariatur dolorem ab maxime nostrum.", "Dolorem reiciendis error consequatur magnam.", null, 0 },
                    { 257, "Aut molestiae non autem in.", "Perspiciatis voluptatem ratione itaque enim atque sed.", null, 0 },
                    { 258, "Aut saepe necessitatibus veritatis enim illo quidem illum vel.", "Et nihil commodi quia dicta sunt odit aut.", null, 0 },
                    { 259, "Voluptatem ducimus ut distinctio molestiae nemo magnam quia.", "Quos id quos maxime reprehenderit voluptatem laborum ipsa voluptas sit.", null, 0 },
                    { 260, "Praesentium ratione qui officia autem nemo dolor porro libero.", "Aut sequi veritatis corporis et sed rerum magni.", null, 0 },
                    { 261, "Numquam et quidem vero vero hic.", "Quibusdam non quas et blanditiis.", null, 0 },
                    { 262, "Hic beatae sed voluptatibus voluptatem ut rerum et voluptate.", "Odio fuga praesentium veritatis inventore atque quidem id doloremque.", null, 0 },
                    { 263, "Fugit quis quos labore non qui ad.", "Quas sit maxime architecto eum officia ipsum neque odit.", null, 0 },
                    { 264, "Omnis voluptas odit dolor ipsa omnis.", "Ipsa et sed tempora qui et.", null, 0 },
                    { 265, "Sit voluptatem aut minus qui dolores quod fugit.", "Iusto sed dolorum quisquam est in repudiandae necessitatibus aliquam placeat.", null, 0 },
                    { 266, "Et dolore quia ratione voluptatem architecto.", "Quis dolor delectus voluptas earum vitae debitis vitae.", null, 0 },
                    { 267, "Ducimus numquam quam ratione sequi odio ducimus.", "Ut ut inventore commodi veniam quidem soluta et a.", null, 0 },
                    { 268, "Voluptatem asperiores maxime rem sit autem minima odio.", "Dolor nesciunt quia magnam accusamus autem ipsa.", null, 0 },
                    { 269, "Qui consequatur earum mollitia veniam qui ut non rem.", "Nihil ad iusto maxime nihil.", null, 0 },
                    { 270, "Officia dolor est qui quidem sit amet est ipsa molestiae.", "In ea deserunt dignissimos omnis voluptate.", null, 0 },
                    { 271, "Officia accusamus impedit aperiam officia.", "Non hic ab quia exercitationem iure dolore quam.", null, 0 },
                    { 272, "Minus totam et magnam quisquam.", "Et tempore ducimus est ipsa ea.", null, 0 },
                    { 273, "Fuga omnis enim totam similique.", "Sint possimus deleniti sequi eum illo quisquam eos libero saepe.", null, 0 },
                    { 274, "Nobis dolore laborum tempore expedita voluptas ut enim nihil occaecati.", "Ut voluptas dolorem rerum alias.", null, 0 },
                    { 275, "Ipsum quos necessitatibus reiciendis expedita consequuntur est perferendis consequuntur nisi.", "Rerum autem aut eius nam.", null, 0 },
                    { 276, "Itaque quaerat nesciunt praesentium inventore et.", "Ab soluta ullam deleniti sunt illum quo molestias et ipsum.", null, 0 },
                    { 277, "Blanditiis ut distinctio asperiores est maxime.", "Veniam culpa consequuntur cum et aut eligendi.", null, 0 },
                    { 278, "Blanditiis perferendis omnis voluptas quisquam.", "Magnam id sint laudantium omnis aut.", null, 0 },
                    { 279, "Et quo labore et dolor reiciendis ipsa quasi esse.", "Qui cupiditate beatae possimus quibusdam laboriosam.", null, 0 },
                    { 280, "Est quos sit eos in odit quidem delectus est.", "Dolore quaerat cupiditate eius eaque.", null, 0 },
                    { 281, "Quo amet reiciendis neque sequi harum veniam et.", "Tempora hic ea rerum nihil cum amet doloribus reiciendis.", null, 0 },
                    { 282, "Nostrum aspernatur ipsum aut saepe non quis.", "Occaecati quidem et expedita placeat unde iusto quidem possimus eius.", null, 0 },
                    { 283, "Rerum facilis et id voluptates ea non veniam sint.", "Perspiciatis dolores ut commodi earum consectetur quia animi ratione minus.", null, 0 },
                    { 284, "Sunt delectus ea temporibus et blanditiis.", "Beatae minus ratione repellat at sunt non.", null, 0 },
                    { 285, "Et eius ut et voluptatem non.", "Corrupti repellat commodi cumque sequi eos incidunt et ex.", null, 0 },
                    { 286, "Quo dignissimos fuga explicabo est ex non exercitationem repellat.", "Nemo harum est dolore assumenda ad rerum quibusdam et voluptas.", null, 0 },
                    { 287, "Est et inventore qui necessitatibus saepe voluptatem est.", "Optio nisi omnis qui expedita voluptatibus.", null, 0 },
                    { 288, "Minima fugiat alias nobis exercitationem ut architecto sapiente.", "Ex excepturi molestiae tempora nemo ut dolores qui ut minima.", null, 0 },
                    { 289, "Necessitatibus quo autem non iusto.", "Delectus in doloribus debitis vero facere labore ratione incidunt.", null, 0 },
                    { 290, "Nesciunt mollitia corrupti eos quod optio harum dolor facere sed.", "Officiis a libero eaque perferendis optio quia.", null, 0 },
                    { 291, "Veritatis laudantium illum sit aut odit aut et voluptatum nihil.", "Ut quidem perspiciatis aliquid libero voluptate aut minima.", null, 0 },
                    { 292, "Dicta mollitia quod ut esse nam dolorum.", "Ipsum quidem commodi corrupti hic doloribus.", null, 0 },
                    { 293, "Maiores quia est a dolorum.", "At culpa voluptas et sit animi.", null, 0 },
                    { 294, "Corporis consectetur et nihil vel ullam.", "Consequatur et suscipit est nihil quas.", null, 0 },
                    { 295, "Maiores consectetur et blanditiis fuga placeat.", "Ducimus expedita optio iure iusto quod eos saepe eum.", null, 0 },
                    { 296, "Animi reiciendis eos ut hic.", "Vel odit est dolores hic assumenda cupiditate.", null, 0 },
                    { 297, "Molestiae quibusdam rerum illum explicabo placeat alias distinctio.", "Est unde ad porro itaque a.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 298, "Sit adipisci et laudantium earum accusantium nihil molestiae.", "Omnis quia consequatur quibusdam ipsum dolorum similique officia hic ad.", null, 0 },
                    { 299, "Dolor est molestiae voluptate fuga tempore aperiam.", "Occaecati deleniti quisquam veniam quis recusandae nemo minima.", null, 0 },
                    { 300, "Corrupti dicta maxime modi incidunt quasi.", "Minima repellendus minus ipsa omnis id rem ipsam velit.", null, 0 },
                    { 301, "Voluptas illo et unde consequatur earum quasi quod tenetur.", "Sit sed in dolores facere sit et architecto a rem.", null, 0 },
                    { 302, "Molestias quo voluptatem voluptas aut ipsam facilis facere.", "Deserunt libero ut at aut.", null, 0 },
                    { 303, "In omnis et qui perspiciatis.", "Tenetur omnis sit qui harum.", null, 0 },
                    { 304, "Ut et dolorem aliquam in voluptas libero.", "Temporibus sit qui officia dolorem incidunt non et.", null, 0 },
                    { 305, "Ut molestiae fugiat cumque qui voluptatem.", "Nemo quasi ipsum dicta sunt non.", null, 0 },
                    { 306, "Nulla est iusto veniam similique modi ea.", "Eum vel ut repellendus quaerat vitae qui.", null, 0 },
                    { 307, "Ipsa eveniet rerum laboriosam et et sequi modi soluta.", "Molestias dolor aut voluptatem et eum illum dolores.", null, 0 },
                    { 308, "Ducimus beatae ducimus aperiam rerum.", "Voluptatibus eum id harum nihil.", null, 0 },
                    { 309, "Quo nesciunt tempora cumque aliquid dolorum voluptatibus.", "Qui iste perspiciatis et hic.", null, 0 },
                    { 310, "Voluptatem eveniet et beatae omnis est.", "Porro sit saepe atque aut.", null, 0 },
                    { 311, "Facilis voluptatem sit molestiae in nam.", "Deserunt fugit velit quis id.", null, 0 },
                    { 312, "Ut expedita est qui et laudantium modi est.", "Id exercitationem id ducimus voluptatem nulla distinctio aperiam asperiores omnis.", null, 0 },
                    { 313, "Reiciendis eaque maxime recusandae quia.", "Dolorem voluptatum mollitia est laboriosam tempora enim voluptas dicta tempore.", null, 0 },
                    { 314, "Nihil eaque autem nisi sint minus voluptatem.", "Voluptas voluptatem repudiandae non magni.", null, 0 },
                    { 315, "Qui dolorum temporibus praesentium neque aut placeat.", "Repellat quibusdam sit et rem recusandae quo laboriosam.", null, 0 },
                    { 316, "Dolorem assumenda suscipit vitae vel sint sequi.", "Voluptas ut aperiam sint debitis nemo corrupti et esse.", null, 0 },
                    { 317, "Vel quam dolorem natus illo ut eos nam.", "Non minima mollitia ducimus rerum alias esse nisi.", null, 0 },
                    { 318, "Facere dolor soluta nihil ut dolores quas reiciendis qui error.", "Ut quisquam blanditiis quis autem et minima quos.", null, 0 },
                    { 319, "Pariatur quo nulla non molestiae voluptates.", "Nemo ullam vitae velit eum autem.", null, 0 },
                    { 320, "Perspiciatis saepe et accusantium dolorem vitae rerum aut.", "Tenetur quo tempore soluta voluptas unde quia voluptas omnis dolorem.", null, 0 },
                    { 321, "Dolores nulla aliquam hic fuga sunt vero hic.", "Fugit delectus odit placeat dolores sint explicabo minima est aut.", null, 0 },
                    { 322, "Est beatae asperiores quam veniam qui autem voluptatem iste aut.", "Cum quisquam minima eum maiores qui dolores corporis.", null, 0 },
                    { 323, "Repellat ut sequi impedit accusamus.", "Optio et id reiciendis praesentium et eaque sint tempora.", null, 0 },
                    { 324, "Quia perspiciatis aut asperiores reiciendis non consequatur odit.", "Hic fuga voluptas in nemo ut eius laudantium occaecati.", null, 0 },
                    { 325, "Explicabo ipsum assumenda perspiciatis veritatis debitis consequatur ipsum.", "Saepe voluptas id minima quisquam voluptatum qui voluptate.", null, 0 },
                    { 326, "Itaque nihil voluptatem reprehenderit facere.", "Repudiandae ipsam qui rerum harum qui ad mollitia nobis.", null, 0 },
                    { 327, "In et natus earum sint nemo laudantium recusandae nostrum vel.", "Excepturi sequi non quas eius.", null, 0 },
                    { 328, "Omnis deserunt ut aut fugiat quam doloremque amet repellendus distinctio.", "Et minima quia blanditiis libero quia laborum doloremque aliquid animi.", null, 0 },
                    { 329, "Unde quos sint expedita dolor incidunt explicabo.", "Ex veritatis laboriosam veniam non.", null, 0 },
                    { 330, "Laboriosam modi in nesciunt cupiditate laudantium sint.", "Error error rem deserunt est qui et magnam et ipsa.", null, 0 },
                    { 331, "Modi suscipit voluptate et qui eos sunt repellat voluptatibus.", "Nam animi fugiat rem quae eos ab voluptatem et.", null, 0 },
                    { 332, "Sed voluptatem veritatis porro in quidem sint laudantium quidem.", "Quibusdam et maiores non aut incidunt.", null, 0 },
                    { 333, "Voluptatem corporis maxime sit eveniet rerum placeat nobis.", "Ut harum aut impedit facilis corporis sed nihil.", null, 0 },
                    { 334, "Voluptate autem in voluptatibus eligendi.", "Ipsam voluptatem voluptas voluptatum quia voluptatem.", null, 0 },
                    { 335, "Molestiae voluptatem odit debitis eum provident dolorum quaerat.", "Ipsam quas sint et qui.", null, 0 },
                    { 336, "Nulla sit pariatur et sunt.", "Minus autem ipsam consectetur velit deserunt neque commodi.", null, 0 },
                    { 337, "Qui rerum aliquam placeat sit dolorem inventore recusandae aut sed.", "Itaque ut tempore autem excepturi rerum et.", null, 0 },
                    { 338, "Sed dolore explicabo aut consequatur et molestias possimus.", "Sint beatae fuga dignissimos ut ad sunt repellat.", null, 0 },
                    { 339, "Sequi sint possimus consequatur error.", "Vitae et quia voluptatibus dolore quod aliquam voluptatibus.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 340, "Aut et omnis incidunt animi reiciendis enim.", "Nemo est blanditiis qui eum.", null, 0 },
                    { 341, "Quas quod ipsum dolorem provident.", "Labore porro fugiat rem eos culpa harum aut quibusdam.", null, 0 },
                    { 342, "Non consequatur et animi illo voluptatem deserunt.", "Qui consequuntur ut fugiat ut ut.", null, 0 },
                    { 343, "Et saepe ut rerum repudiandae id quo ut.", "Accusamus corrupti veniam nam laboriosam qui corrupti fugiat.", null, 0 },
                    { 344, "Quo eaque voluptatem magni pariatur autem.", "Voluptas ut quae quo temporibus tenetur similique quae.", null, 0 },
                    { 345, "Et doloremque suscipit repellat repudiandae maiores et repellendus eaque.", "Dolorum numquam sed excepturi et eius id ipsa deleniti quos.", null, 0 },
                    { 346, "Ut possimus illum et veniam aut molestias.", "Veritatis dignissimos ea qui est voluptas.", null, 0 },
                    { 347, "Animi sed fuga voluptatibus nisi quia.", "Maiores odio iure voluptatibus ut.", null, 0 },
                    { 348, "Saepe velit dolor recusandae nesciunt est tempora voluptas.", "Cum pariatur commodi optio dolor.", null, 0 },
                    { 349, "Laborum a placeat facilis eum.", "Odio quia illo ut dolor et iusto sit qui saepe.", null, 0 },
                    { 350, "Saepe hic non illum et eaque sed.", "Aut molestias blanditiis molestiae sequi praesentium.", null, 0 },
                    { 351, "Hic labore eveniet mollitia voluptatem quo earum omnis.", "Cupiditate voluptas aspernatur vel quisquam ut qui pariatur.", null, 0 },
                    { 352, "Cumque quis est laudantium eaque quisquam recusandae quis eius.", "Amet nulla explicabo nobis consequuntur necessitatibus qui ex quibusdam aut.", null, 0 },
                    { 353, "Consequuntur aspernatur corrupti aliquid excepturi corporis aut sit.", "Nostrum quo rerum excepturi ullam.", null, 0 },
                    { 354, "Nulla aut nostrum voluptatem doloremque unde.", "Voluptatibus doloribus sapiente placeat qui occaecati ut repellendus ipsum.", null, 0 },
                    { 355, "Atque et non sequi nihil expedita impedit laborum.", "Similique necessitatibus amet nobis et et tempora et earum.", null, 0 },
                    { 356, "Officia quam qui et officia voluptas cumque ea consectetur est.", "Eum a vitae doloremque odit non quia suscipit qui.", null, 0 },
                    { 357, "Eveniet voluptas molestiae numquam consequatur ducimus eveniet vel et.", "Aspernatur nemo inventore similique sed pariatur placeat necessitatibus earum.", null, 0 },
                    { 358, "Soluta accusamus ut tempore vitae excepturi accusantium distinctio placeat doloribus.", "Voluptatem repellat et fugit dicta nisi qui quos molestias ut.", null, 0 },
                    { 359, "Quos sunt sint sunt esse dolores ullam.", "Officiis natus vel quam commodi necessitatibus velit fuga.", null, 0 },
                    { 360, "Nam rerum et delectus enim ut.", "Corporis libero labore qui vero.", null, 0 },
                    { 361, "Labore sunt quos nobis sed optio ab iure.", "Ut inventore ipsa doloremque corrupti quasi assumenda.", null, 0 },
                    { 362, "Qui dolorem voluptatem a fugiat dolorum rerum voluptatem distinctio quod.", "Est ut sed possimus iusto rerum minus unde non.", null, 0 },
                    { 363, "Nulla ex sed sit quas dolores aut in voluptate et.", "Odio eum soluta quaerat recusandae quidem aut delectus ratione.", null, 0 },
                    { 364, "Temporibus quas et aut ea animi.", "Id sint delectus molestiae eos.", null, 0 },
                    { 365, "Vel voluptatibus rerum officia expedita.", "Qui corrupti aut est nulla ut sed alias.", null, 0 },
                    { 366, "Quo necessitatibus beatae velit illo quia deserunt dolor molestiae autem.", "Sed autem vero neque repudiandae dolore consequatur.", null, 0 },
                    { 367, "Quia blanditiis doloremque fugit non atque consequatur ut autem molestiae.", "Et sit voluptas veritatis voluptate id ipsa laboriosam.", null, 0 },
                    { 368, "Ut optio sunt saepe aliquid explicabo.", "Dolorem facere qui repudiandae aut maiores illo ea nisi.", null, 0 },
                    { 369, "Qui neque rerum est fugiat voluptates voluptatem accusamus est placeat.", "Amet quae commodi fugiat neque velit quis enim dolor rem.", null, 0 },
                    { 370, "Molestias aut hic voluptatem voluptate.", "Repudiandae omnis accusamus qui aut mollitia quisquam laborum.", null, 0 },
                    { 371, "Dicta sint molestias qui maxime non ducimus.", "Dicta voluptas aut quidem voluptates officia ut et.", null, 0 },
                    { 372, "Perferendis aut commodi eum sapiente.", "Quia quia non exercitationem non non.", null, 0 },
                    { 373, "Esse quaerat rerum iste est et.", "In iure optio animi quam non autem.", null, 0 },
                    { 374, "Eveniet eum explicabo molestiae totam deserunt et dolor consequatur.", "Pariatur ipsum qui labore consequatur ut quia.", null, 0 },
                    { 375, "Qui qui voluptatem autem est.", "Ad exercitationem qui qui corporis eum est est.", null, 0 },
                    { 376, "Ut quisquam quos a est.", "Quod fugit minima sunt adipisci.", null, 0 },
                    { 377, "Ullam perspiciatis iste blanditiis sed aut.", "Eveniet maxime nam eos blanditiis perferendis.", null, 0 },
                    { 378, "Voluptate harum ratione veritatis est sequi ea.", "Asperiores quo rerum neque maiores et ut consectetur.", null, 0 },
                    { 379, "Magnam quia qui rerum necessitatibus consequatur omnis doloribus.", "Tenetur ab dolore quisquam soluta velit esse autem quod.", null, 0 },
                    { 380, "Saepe laborum aut eum tempore et aut enim alias sit.", "Placeat ut saepe voluptatum voluptas at odit.", null, 0 },
                    { 381, "Numquam voluptatem aut natus nostrum unde ipsam architecto.", "Velit voluptas veritatis dicta numquam vel inventore exercitationem.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 382, "Consequatur sunt aperiam asperiores et est voluptas minima vero quisquam.", "Quae aut autem libero debitis et temporibus.", null, 0 },
                    { 383, "Numquam eius non eaque et est.", "Mollitia aut accusamus earum saepe hic architecto consequatur rem.", null, 0 },
                    { 384, "Delectus fugiat ut non aut quidem cupiditate.", "Eos vel totam quos qui.", null, 0 },
                    { 385, "Voluptates similique dolores quas voluptatem tempora odio rerum.", "Dolores vero consequuntur repellendus magni libero quia.", null, 0 },
                    { 386, "Ut id quasi quo eaque odio et.", "Corporis magnam suscipit maiores rem saepe similique nobis natus voluptatem.", null, 0 },
                    { 387, "Eos ut rerum repellendus quam vero quia.", "Harum quas quaerat fuga aut assumenda sapiente labore recusandae ea.", null, 0 },
                    { 388, "Mollitia ut et explicabo dolorem blanditiis et enim.", "Vel perspiciatis qui maiores qui facere aut molestiae perspiciatis.", null, 0 },
                    { 389, "Quia temporibus aspernatur accusantium libero.", "Dolorem mollitia magni asperiores officia cumque quisquam qui.", null, 0 },
                    { 390, "Est eaque optio repudiandae dicta eos quam qui repellendus exercitationem.", "Ut qui quaerat qui ut eum ad.", null, 0 },
                    { 391, "Sit corrupti aliquam possimus consequuntur quasi sunt cumque quos.", "Dolor quaerat molestiae nostrum ad corrupti aliquam dolorem dolor.", null, 0 },
                    { 392, "Velit nulla animi iusto architecto necessitatibus.", "Voluptas occaecati sed quasi quia fugit aut.", null, 0 },
                    { 393, "Excepturi beatae aut commodi nostrum maiores.", "Eveniet nesciunt sunt odio autem.", null, 0 },
                    { 394, "Possimus provident consequatur sapiente quod dolorum.", "Facere consequatur porro quis nisi voluptatum aliquid.", null, 0 },
                    { 395, "Veritatis fugiat possimus soluta dolor vel.", "Ratione ducimus a consequatur minus.", null, 0 },
                    { 396, "Aut nostrum fuga quasi enim autem accusamus est numquam.", "Praesentium soluta ad doloribus qui et et voluptatem qui et.", null, 0 },
                    { 397, "Ut quia quod quia nihil consequatur voluptatibus.", "Sed ullam reiciendis voluptate corrupti qui quos illum consequatur.", null, 0 },
                    { 398, "Quae voluptas pariatur dicta voluptatum.", "Quia modi mollitia sint quis iure.", null, 0 },
                    { 399, "Laborum cupiditate non soluta dolorum.", "Quisquam ab totam praesentium culpa.", null, 0 },
                    { 400, "Ad aliquam et rerum dolorem et ipsam incidunt.", "Aut fugit soluta laboriosam ut amet expedita fuga debitis harum.", null, 0 },
                    { 401, "Ratione in rerum ut harum.", "Aliquid odit expedita nostrum asperiores adipisci quod accusamus rerum corrupti.", null, 0 },
                    { 402, "Alias dolorum temporibus sint occaecati rem repellendus eum qui.", "Quae qui veniam ea minima quisquam a error quo vitae.", null, 0 },
                    { 403, "Sunt natus inventore quidem eos debitis commodi veniam assumenda.", "Possimus eum possimus in enim.", null, 0 },
                    { 404, "Expedita aut et et eos.", "Molestiae non quisquam iste quasi qui a vel.", null, 0 },
                    { 405, "Temporibus ad et natus similique.", "Maiores a ipsa natus quia ab libero recusandae.", null, 0 },
                    { 406, "Maxime odit labore mollitia rem ab laborum saepe.", "Sint dolore voluptatem aut beatae reiciendis nihil non esse et.", null, 0 },
                    { 407, "Voluptatem voluptatem sint ut ipsam deleniti consequatur.", "Dolorum labore sed qui ullam tempore quasi sit voluptatem ducimus.", null, 0 },
                    { 408, "Omnis ut qui culpa autem illo.", "Aut rerum ab vero magni mollitia sit neque fuga ut.", null, 0 },
                    { 409, "Assumenda excepturi nihil eum corrupti laudantium repellat aut asperiores impedit.", "Et amet et sunt aut et culpa consequatur perspiciatis.", null, 0 },
                    { 410, "Fuga eaque quo ut et.", "Id minima laboriosam accusantium sed sapiente quia quasi est.", null, 0 },
                    { 411, "Enim hic qui earum quisquam praesentium tempore itaque id.", "Soluta voluptatem dolore libero error impedit at voluptatibus dolor.", null, 0 },
                    { 412, "Ad natus odio unde magnam.", "Excepturi quaerat eos possimus voluptas.", null, 0 },
                    { 413, "Doloribus quo quia aperiam autem delectus quod illum laudantium nulla.", "Sunt dolorem est iusto a quas possimus.", null, 0 },
                    { 414, "Eum molestiae maiores reprehenderit id sed magni similique animi voluptatum.", "Iste maxime facere vel facere.", null, 0 },
                    { 415, "Animi illo nostrum quos voluptatum et perspiciatis nam dolorem velit.", "Dolorem ea maiores praesentium ut soluta.", null, 0 },
                    { 416, "Omnis quia saepe repellendus accusamus quia quia voluptatem.", "Itaque dicta repellat quis ipsam porro fugit.", null, 0 },
                    { 417, "Perferendis repudiandae voluptate eum voluptatem aut sit reiciendis voluptatum.", "Esse optio veniam ad ipsam fugit saepe sed est.", null, 0 },
                    { 418, "Culpa et est totam est sit impedit possimus iure.", "Alias reiciendis sunt officia temporibus ipsum.", null, 0 },
                    { 419, "Laudantium illo hic dolorum molestias.", "Exercitationem alias rerum et ab deleniti.", null, 0 },
                    { 420, "Odit perferendis labore praesentium nostrum quas minus.", "Reiciendis sunt consequatur error beatae aut perferendis et assumenda voluptatem.", null, 0 },
                    { 421, "Et reiciendis voluptas explicabo cupiditate corporis.", "Aut non cum harum in repellat sit consequuntur consequatur.", null, 0 },
                    { 422, "Voluptas provident expedita suscipit omnis corrupti.", "Ad totam labore aut molestiae modi possimus qui et voluptatem.", null, 0 },
                    { 423, "Unde minus sequi quia sunt nulla autem eum consequatur doloribus.", "Sunt veniam ut mollitia sit at quos ducimus sunt eum.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 424, "Ad ullam in cumque repellat magnam temporibus.", "Sint eos explicabo aliquid aut recusandae.", null, 0 },
                    { 425, "Totam exercitationem delectus error reiciendis veniam.", "Ipsum accusamus ipsum corrupti qui voluptas molestiae illum.", null, 0 },
                    { 426, "Voluptate et ut facilis consequuntur accusantium dolore aliquam iusto.", "Sit tempore aut dicta distinctio reprehenderit sequi quaerat culpa.", null, 0 },
                    { 427, "Fuga veritatis sed perferendis perspiciatis dolorum commodi.", "Error officiis dicta praesentium nobis.", null, 0 },
                    { 428, "Deleniti ea dolorum harum ex assumenda.", "Illo cum consequatur modi labore iste quo eaque doloremque est.", null, 0 },
                    { 429, "Aut sit eum doloribus voluptatem voluptatem autem totam.", "Optio commodi expedita quos voluptatem deserunt ipsam.", null, 0 },
                    { 430, "Architecto omnis itaque illo quo sed.", "Odio in nam in magnam est ipsam delectus nostrum sint.", null, 0 },
                    { 431, "Eius dicta aperiam non autem.", "Inventore quia similique tempora quo neque ut occaecati quisquam sit.", null, 0 },
                    { 432, "Tempora esse illo incidunt aut consequatur sunt tempora ut pariatur.", "Vel quibusdam atque consequatur amet aut ipsum.", null, 0 },
                    { 433, "Nihil vitae eum esse blanditiis.", "Facilis dolor qui ullam et et.", null, 0 },
                    { 434, "Laboriosam voluptatem magnam quo laboriosam.", "Et esse tempora dicta aperiam.", null, 0 },
                    { 435, "Sit molestiae aut aliquam voluptate eveniet suscipit placeat neque.", "Inventore nihil consequatur voluptatem vel aut autem fugit asperiores.", null, 0 },
                    { 436, "Magnam dicta illum nobis ad.", "Quis perspiciatis fugit ut cum voluptatem qui libero maxime.", null, 0 },
                    { 437, "Excepturi assumenda voluptatem provident molestiae.", "Earum sunt qui officia unde ea eveniet.", null, 0 },
                    { 438, "Voluptas rem ut iusto at sequi sit fugit sint.", "Occaecati temporibus aut laudantium velit.", null, 0 },
                    { 439, "Reprehenderit veritatis qui est qui blanditiis.", "Aut consequatur non id sapiente et aut non pariatur.", null, 0 },
                    { 440, "Voluptas dolor eaque alias velit qui dolor.", "Harum illum velit labore culpa et quia sint ab dignissimos.", null, 0 },
                    { 441, "Aut similique rerum neque ipsum id est qui molestiae est.", "Sit cum ratione ipsam eum quas.", null, 0 },
                    { 442, "Ut quis voluptatem quia molestias dolorem.", "Repellat pariatur incidunt et officiis esse.", null, 0 },
                    { 443, "Qui illum expedita molestiae sint possimus sed voluptatum facilis.", "Provident qui magnam ipsum cupiditate ipsam beatae nisi sequi consequuntur.", null, 0 },
                    { 444, "Quia nobis beatae vel minima voluptas qui aut.", "Ut accusantium doloremque eaque ipsa aspernatur nam est.", null, 0 },
                    { 445, "Delectus neque nemo distinctio facere.", "Nisi voluptate voluptatem est adipisci qui sed iste earum.", null, 0 },
                    { 446, "Sit autem aut quia rem incidunt.", "Consequatur est dolore id officiis sapiente debitis vero vel.", null, 0 },
                    { 447, "Et quia fugit velit accusantium expedita.", "Soluta inventore alias ut occaecati nisi animi.", null, 0 },
                    { 448, "Aut cumque nostrum rerum optio perspiciatis.", "Doloribus blanditiis ut et perspiciatis est.", null, 0 },
                    { 449, "Voluptates repudiandae ipsam alias voluptates incidunt quia in.", "Necessitatibus totam dolorum non mollitia qui.", null, 0 },
                    { 450, "Qui officia hic cupiditate ut omnis eligendi.", "Hic velit asperiores ea doloremque cum reiciendis.", null, 0 },
                    { 451, "Vero quae et id sed.", "Architecto ut odit sed itaque eius ipsum consectetur.", null, 0 },
                    { 452, "Asperiores quia dolores molestiae autem aut molestias.", "Sint voluptatem nostrum quia libero facilis totam voluptas omnis.", null, 0 },
                    { 453, "Hic dolorem aut exercitationem exercitationem qui dolorem numquam rem fugiat.", "Quibusdam et est mollitia quia doloribus earum a ratione doloribus.", null, 0 },
                    { 454, "Cupiditate quo et dolorem sunt similique velit.", "Earum quas nemo accusamus eaque molestias.", null, 0 },
                    { 455, "Placeat ad nihil at velit eum.", "Adipisci natus incidunt optio saepe nam voluptatum debitis.", null, 0 },
                    { 456, "Dolorum eligendi recusandae sit odit nihil iusto similique accusantium suscipit.", "Expedita ut laudantium cupiditate error ea et tempore.", null, 0 },
                    { 457, "Et culpa saepe illo ut aut veritatis natus voluptatem.", "Cupiditate distinctio reiciendis facere doloremque quibusdam voluptatibus alias provident.", null, 0 },
                    { 458, "Aut magni aliquam officia dolorem voluptatum ipsum quia adipisci nam.", "Et consectetur quasi dignissimos modi.", null, 0 },
                    { 459, "Consequatur molestiae enim et sunt sequi magni ex vitae.", "Quia qui necessitatibus magnam natus laudantium itaque.", null, 0 },
                    { 460, "Id minus in velit aut est expedita fugiat sint aut.", "Corrupti natus unde officiis atque tempora delectus ex deleniti.", null, 0 },
                    { 461, "Quo reiciendis nostrum ea sed non.", "Soluta placeat dolorum saepe ex sint.", null, 0 },
                    { 462, "Non voluptas cum ex dolor et a doloremque nulla.", "Natus aut dicta enim rerum suscipit at.", null, 0 },
                    { 463, "Hic quia sit qui nihil saepe rem voluptatum culpa.", "Nostrum blanditiis totam quia eius quam qui et recusandae quam.", null, 0 },
                    { 464, "Expedita sint quo reprehenderit unde rerum dolorum molestiae similique quasi.", "Ut natus quam nam voluptate et.", null, 0 },
                    { 465, "Accusantium accusantium voluptas accusamus tempora maxime blanditiis assumenda est repellendus.", "Totam est reprehenderit expedita maxime.", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "Name", "PhotoId", "State" },
                values: new object[,]
                {
                    { 466, "Sed minus dolorum et minima reiciendis voluptas odit dolorem ipsa.", "Rem et enim et ut sit quaerat possimus.", null, 0 },
                    { 467, "Itaque ipsum et reiciendis nihil pariatur voluptas modi accusantium eaque.", "Et et nihil adipisci architecto consectetur.", null, 0 },
                    { 468, "Ea et odit delectus non et.", "Ipsum modi omnis veniam ut ex repellendus placeat.", null, 0 },
                    { 469, "Sequi quo dolorum vitae veritatis nihil.", "Ut non ratione inventore et cumque aut sunt aut.", null, 0 },
                    { 470, "Tempore dolorem eius dolor impedit.", "Maxime eius nobis optio voluptas consequatur.", null, 0 },
                    { 471, "Rem perspiciatis laudantium quos non.", "Laborum inventore incidunt velit optio assumenda ipsum dolor dolorem doloremque.", null, 0 },
                    { 472, "Omnis neque qui perspiciatis alias ab sapiente et laudantium tempore.", "Praesentium eius est nostrum ipsum modi nemo porro eius aut.", null, 0 },
                    { 473, "Aperiam consequatur voluptas itaque eos ea error sapiente aut facere.", "Id quia soluta omnis quia nemo aut quidem.", null, 0 },
                    { 474, "Et pariatur quibusdam non laboriosam nulla voluptatem blanditiis nam.", "Tempora totam et eveniet eius consequatur eos ut quisquam laboriosam.", null, 0 },
                    { 475, "Incidunt repudiandae delectus quidem iure.", "Nobis similique sed beatae aliquam rem.", null, 0 },
                    { 476, "Veritatis earum dolor porro voluptatem.", "Quidem minus aut adipisci culpa sint.", null, 0 },
                    { 477, "Eum assumenda velit quia voluptatem debitis eveniet molestiae molestias.", "Nobis consectetur harum doloremque quam ullam vel perspiciatis illum.", null, 0 },
                    { 478, "Rerum culpa eos sapiente neque.", "Quam praesentium et non aut dolores dolorem porro dolore modi.", null, 0 },
                    { 479, "Fugit voluptates eos ipsum nam.", "Itaque qui repellat voluptas qui commodi.", null, 0 },
                    { 480, "Ut et ut impedit deleniti voluptatibus sint omnis ut.", "Voluptates ut et occaecati consequatur facere est cumque ullam.", null, 0 },
                    { 481, "Nostrum quod iusto sit et reprehenderit molestiae atque.", "In eligendi odio voluptas ratione hic.", null, 0 },
                    { 482, "Consequuntur fuga et iste quia ipsa.", "Ut qui error animi atque et.", null, 0 },
                    { 483, "Minus in similique voluptates quis culpa non.", "Vitae alias aut eligendi pariatur.", null, 0 },
                    { 484, "Quae qui quos error voluptatem sint et vel nostrum.", "Placeat est placeat sequi non.", null, 0 },
                    { 485, "Perferendis voluptatem fuga aliquam et qui et fugiat dolore provident.", "Earum aperiam aliquid ab nisi aut consequatur.", null, 0 },
                    { 486, "Debitis et eos ex facere neque eum iusto fugiat.", "Tempore quia accusamus culpa commodi est qui totam placeat.", null, 0 },
                    { 487, "Minima sequi perferendis reprehenderit ab et et pariatur.", "Aut sit facere aut culpa incidunt architecto modi.", null, 0 },
                    { 488, "Eveniet provident qui vero tempore fugiat voluptas explicabo ut.", "Est similique autem inventore corporis qui voluptatem dolores eum.", null, 0 },
                    { 489, "Corporis officiis et totam in dicta enim consequatur.", "Quia nihil autem quo et voluptates et architecto.", null, 0 },
                    { 490, "Modi tempore quibusdam incidunt magnam accusamus voluptatem in asperiores nihil.", "Voluptatem aut harum facere consequuntur est.", null, 0 },
                    { 491, "Dolorum aut in enim amet incidunt quia non.", "Qui non aperiam in perspiciatis totam aut et.", null, 0 },
                    { 492, "Molestias rerum modi ea et non quo illum esse aliquid.", "Explicabo architecto maiores architecto eveniet velit.", null, 0 },
                    { 493, "Itaque est ratione ab voluptate sunt quia.", "Voluptatibus qui optio est qui vero non voluptas consequatur.", null, 0 },
                    { 494, "Eveniet asperiores incidunt sunt sed optio et labore.", "Aut voluptate sapiente odio dolorem non voluptatem dolorem possimus.", null, 0 },
                    { 495, "Ipsam adipisci dolor similique dolor similique quos praesentium inventore sapiente.", "Omnis rem autem repellendus numquam enim.", null, 0 },
                    { 496, "Commodi et eum itaque ad quaerat animi ut voluptatem.", "Molestiae aut temporibus ut nam.", null, 0 },
                    { 497, "Sequi rerum vitae laudantium neque.", "Sit exercitationem molestiae facere reiciendis.", null, 0 },
                    { 498, "Illum est pariatur laborum rerum.", "Eum vero doloremque dolores quod.", null, 0 },
                    { 499, "Mollitia ut officia rerum esse asperiores.", "Corrupti exercitationem quis quibusdam eligendi dolor.", null, 0 },
                    { 500, "Quam impedit itaque debitis ut eligendi voluptatem ut eveniet rem.", "Consequatur aut earum itaque consequuntur consectetur qui doloremque.", null, 0 },
                    { 501, "Rerum illum omnis dolores error sed totam autem est.", "Eaque quisquam ipsa aut iure velit quia minima.", null, 0 },
                    { 502, "Rerum ab minima facere aut et dolores et.", "Quia et eligendi beatae et nesciunt et.", null, 0 },
                    { 503, "Consequatur est est quibusdam ut totam placeat nulla hic.", "Dolores eos tempora animi nam sed in sed velit provident.", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers",
                column: "PhotoId",
                unique: true,
                filter: "[PhotoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers",
                column: "PhotoId",
                principalTable: "FileDescriptions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers");

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PhotoId",
                table: "Offers",
                column: "PhotoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_FileDescriptions_PhotoId",
                table: "Offers",
                column: "PhotoId",
                principalTable: "FileDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
