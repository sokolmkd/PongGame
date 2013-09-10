# За играта
Понг е една од првите видео игри која е претставена во далечната 1972 година од страна на Atari Incorporated (Atari). Се работи за дводимензионала игра која симулира пинг-понг. Играчот контролира една палка којашто се наоѓа на левата страна од компјутерскиот екран и може да се натпреварува против компјутерот или против друг играч кој ја контролира втората палка сместена на десната страна од екранот. Палките се движат вертикално нагоре или надоле со цел да го фатат. Поените се добиваат доколку противникот не успее да ја врати топката и целта на играчот е да постигне повеќе поени од неговиот противник. 
# Имплементација
Нашата имплементација на играта е малку различна , играчот има 5 животи , и се додека не ги изгуби 5тте животи се обидува да постигне најголем можен број на поени , добивајќи по 10 поени за секое враќање на топката и губење живот доколку не успее да ја врати. Има 3 нивоа на тежина од кои во секое од нив брзината на топката е различна и веројатноста компјутерот да згреши при враќањето (или следењето ) на топката се намалува од помалите нивоа кон поголемите. Изборот за тежина на играта се појавува во првата форма при избор на Single Player. Има можност за избор на Easy, Medium , Hard и Ninja.
Нинџа модот е концептуално различен . Бидејќи е направен само за забава , компјутерот секогаш без да згреши ја враќа топката. На секои десетина секунди се појавуваат цигли на екранот кои го попречуваат движењето на топчето и го враќаат назад кон играчот. Со секое враќање се руши една цигла. Исто така на случајни времиња излегуваат бонуси со коишто може да се зголеми , намали палката на играчот , да се изрушат сите цигли моментално на екранот се до наредно појавување и слично.

## Имплементацијата на играта е следнава :

### Класата Palka ги содржи следните:
 Атрибути:
* PictureBox Pbox - слика за палката
* Size Golemina - големина на палката
* bool AI - проверка дали е бот за соодветно активирање на методите 

Методи:
      ![Player_mov](http://s15.postimg.org/oysum2cnf/Player_Movement.png)   

- движење на ботот: Оваа функција го дефинира движењето на ботот кога играме Single Player.Функцијата прима 5 аргументи, Точката сегашна, у-координата на претходната позиција , брзината на топката и топчето. Најпрво генерираме еден рандом број кој произволно е земен да биде во опсег од 0 до 25. Имаме променлива raz која ја ставаме да биде разликата помеѓу сегашната у-координата и претходната. Доколку бројот кој го генериравме рандом биде под 5 тогаш оваа разлика станува нула и со тоа поместувањето на палката во овој gameTick ќе биде нула. Тоа ни овозможува доколку имаме среќа и знаење да го победиме ботот. Кодот под ова вклучува flag само за да провериме доколку е нинџа мод  ботот да биде непобедлив.
![Ninja mod](http://s1.postimg.org/l9toy8fr3/pivo.png)

     
 - движење при избор на "TwoPlayer" мод од менито. Овој метод реагира на одредени копчиња притиснати од тастатура, односно W и S доколку сакаме да ја движиме плавата палка , т.е. палката од лево на екранот и  UP , DOWN доколку сакаме да ја придвижуваме црвената палка односно палката од десно. Во овој метод има 4 if -a кој едноставно реагираат на стиснатите копчиња кои ги наведовме погоре.

### Класата Topka ги содржи следните атрибути:
* int SpeedX - брзина на топката по X-оската
* int SpeedY - брзина на топката по Y-оската
* OvalPictureBox Pbox – OvalPictureBox e класа која наследува од  PictureBox  , но ја изменува со креирање на регион и тоа го прави да добие изглед на круг.
Во конструкторот на оваа класа креираме објект од типот OvalPictureBox.

### Класата Igra 
Ги содржи сите потребни методи за одвивање на играта при различни избори од Game Menu. 
Во оваа класа се наоѓа Timer како и Timer Tick евентот. Во Timer_Tick() методот се содржат сите прецртувања на следната позиција на топката, позициите на палките , додавањето на цигли доколку сме во нинџа мод, додавањето бонуси доколку сме во нинџа мод , броењето животи  . Додавањето на цигли додека сме во нинџа мод вклучува 2 рандом бројчиња . Првиот се однесува за колку време да се појават нови цигли на средина на формата . Овој број е рандом помеѓу 300 и 500 , што значи дека на секој 300 до 500 game_tick() ќе се нацртаат нови цигли. Вториот рандом број се однесува на позициите на циглите по Додавањето на цигли додека сме во нинџа мод вклучува 2 рандом бројчиња . Првиот се однесува за колку време да се појават нови цигли на средина на формата . Овој број е рандом помеѓу 300 и 500 , што значи дека на секој 300 до 500 game_tick() ќе се нацртаат нови цигли. Вториот рандом број се однесува на позициите на циглите по X и Y координатите. Додавањето се врши со повикување на метод dodaj_ninja() кој го врши горе опишаното . Исто така во Timer_Tick() се повикува и gameAreaColisions() методот. Тука проверуваме дали топката излегува од границите на формата и доколку излегува и ја менуваме насоката. Ова се однесува на горната и долната граница од формата , секако доколку топката излегува од левата или десната граница на формата , некој од играчите изгубил при што го повикуваме resetBall() методот. Методот resetBall() ја враќа топката назад во формата и соодветно намалува животи доколку е потребно.
Во класата Igra и Palka се чуваат приватни променливи од Form1 за добивање на потребните координати.

Формата Game Menu е направена за избор на различни модови на играта. Во неа може да се најде и метод кои ги сортира првите десет најдобри игри и ги прикажува како најдобри резултати. Резултатите се запишуваат во датотека со име “highscore.dat” .

![Pocetno Meni](http://s2.postimg.org/othib0js9/Screenshot_1.png)

Формата Izrabotile е форма која се отвора кога ќе се притисме на копчето About  од привата форма. Тука едноставно се прикажуваат некои правила на играта и кој ја изработиле.

![Izrabotile](http://s23.postimg.org/wypl7p0fv/Izrabotile.png)
