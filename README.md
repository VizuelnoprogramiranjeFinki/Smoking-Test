# Smoking-Test
<span id="OLE_LINK1" class="anchor"><span id="OLE_LINK2"
class="anchor"></span></span>

##1. Објаснување на проблемот


Мојата цел беше да изработам Windows Forms апликација која што ќе
претставува квиз кој ќе определи каков тип на пушач е тој што ќе ја
пополни формата. Формата се состои од наслов и објаснување, како и 6
прашања со 4 понудени одговори, организирани во посебни форми. Откако ќе
се пополнат формите, ќе се отвори нова форма (а претходната ќе се
затвори) и во таа нова форма ќе пишува колку проценти на скалата освоил
тој што ја пополнувал формата. На крај, врз основ на процентите, во
лабели на втората форма, програмот ќе му „каже“ на корисникот каков тип
на пушач е (постојат 3 типа), како и совети за тоа дали треба нешто да
направи околу тоа и доколку да, што треба да направи.

Инаку, идејата за овој проект кој го имплементирав беше **оригинално
моја** и **не ја копирав од никаде**.

<span id="OLE_LINK1" class="anchor"><span id="OLE_LINK2"
class="anchor"></span></span>

##2. Опис на решението на проблемот

Прво ја „нацртав“ **првата форма**, во која имаше вовед во тестот, со
слика, како и копче да се започне со тестот и копче да се излезе од
апликацијата. Потоа**,** следува форма во која се внесува **возраста**
(**малолетници не смеат да го пополнуваат тестот**). Доколку корисникот
напише дека има **18 години** или повеќе, следуваат **6** **форми**, а
во секоја од нив има една лабела која го претставува прашањето, како и
четири **RadioButtons** кои ги претставуваа можните одговори. Во
спротивно, се појавува **ErrorProvider** кој „кажува“ дека само
полнолетни смеат да го пополнуваат тестот.

Податоците се чуваат во класи кои содржат **5 или 6** **public int**,
како и **Default конструктор** и **конструктор со аргументи**. Всушност,
во тие **6** **public int** променливи се чуваат целобројни податоци за
тежината на одговорот на секое од 6-те прашања, како и сума ДО формата и
одговор на тековното прашање. Инаку, првиот одговор во секое прашање
носеше **тежина** 0, вториот 1, третиот 2 и четвртиот 3.

Кога ќе се пополнат сите 6 прашања, **се покажува последната форма**, во
која се наоѓа **резултатот од тестот**, изразен во **проценти** (има и
**Progress Bar)**, како и **категоријата** на пушач и **совети** за
понатаму.

***ВАЖНО:* Формите ги направив *RESPONSIVE*, ја сменив стандардната
икона на формите (од кутија во цигара) и исто така копчињата во 6-те
форми со прашања се во вид на слики, наместо стандардно (со кутија).
Впрочем, левото копче кое служи за излегување од апликацијата е во вид
на црвена слика со форма на X, додека десното копче кое служи за
навигација кон наредното прашање е во вид на зелена стрелка.**

##3.Опис на функцијата за настатот клик на копчето со текст „Каков вид на пушач сум?“

Следува изворниот код од функцијата на копчето од втората форма (со
првото прашање), кое треба да води кон отворање на третата форма (со
второто прашање):


```cs
private void button1_Click(object sender, EventArgs e)
{
	Form3 forma3 = new Form3();
	if (prasanje.prasanje1==-1)
		MessageBox.Show
		("Не можете да преминете на наредното прашање без да го одговорите ова!",
		"Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
	else
	{
		forma3.start(prasanje.prasanje1);
		this.Visible = false;
		forma3.Show();
	}
}
```
Најпрво, инстанцирам објект од класата **Form3**, за да можам доколку е
сè во ред, да преминам од Form2 во Form3, како и да му ги пренесам
**податоците** на **Form3**.

Потоа со **if**-условот проверувам дали првото прашање **НЕ Е
одговорено**. Доколку не е одговорено, ќе има вредност **-1** (бидејќи
иницијалната вредност на прашањето е -1). **Доколку е одговорено** пак,
ќе има вредност **0, 1, 2 или 3** (во зависност од тежината).

Доколку е исполнет условот, односно првото прашање **НЕ Е ОДГОВОРЕНО**,
во тој случај се појавува **MessageBox** со порака за **ГРЕШКА** и со
копче **OK**.

Доколку пак не е исполнет условот, односно првото прашање **Е
ОДГОВОРЕНО**, тогаш се повикува функцијата **public void start (int a)**
од инстанцираниот објект од третата форма, на која како аргумент и се
дава вредноста на прашањето (тежината од 0 до 3). Потоа, **се сокрива
втората форма и се појавува третата форма**.

##4. PrintScreens од изгледот на аплкацијата и кратко упатство како се користи истата

PrintScreen од почетниот изглед на апликацијата (првата форма).

![Alt text](/PrintScreens/PrtScr_1.png)

PrintScreen од изгледот на апликацијата доколку се притисне копчето за
излез од апликацијата.

![Alt text](/PrintScreens/PrtScr_2.png)

PrintScreen од формата за внесување на возраст.

![Alt text](/PrintScreens/PrtScr_3.png)

PrintScreen од ErrorProviderot во формата за внесување на возраст,
доколку се внесе возраст помала од 18 години.

![Alt text](/PrintScreens/PrtScr_4.png)

PrintScreen од формата со првото прашање (сите наредни 5 форми се со ист
изглед).

![Alt text](/PrintScreens/PrtScr_5.png)

PrintScreen од последната форма која ги прикажува резултатите.

![Alt text](/PrintScreens/PrtScr_6.png)
