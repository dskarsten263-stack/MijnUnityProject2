# MijnUnityProject2
# Module 2
## Titel

**RegPin**

## Genre

Physics-based arcade puzzelgame.

## Beschrijving

In RegPin schiet de speler een magische pinbal omlaag een speelveld vol bumps, rotsen en targets in. Wanneer de bal objecten raakt, krijgt de speler punten en kunnen speciale effecten worden geactiveerd, geïnspireerd door de stijl van Peglin. Het doel is zo veel mogelijk punten te behalen binnen één beurt.

## Gameplaykern

1. **Bal**: Een magische runesteen-bal die stuitert en lichteffecten geeft bij impact.
2. **Targets of bumps**: Houten targets, magische kristallen en stenen pegs die punten opleveren en kunnen verdwijnen.
3. **Score**: Je krijgt punten voor elke hit – standaard 10 punten, speciale kristallen geven 25 punten.
4. **Doel**: Een geslaagde beurt is wanneer je voldoende punten hebt behaald voordat de bal de onderkant raakt. Levels kunnen later doelen hebben zoals score-minimums of speciale targets.

## Stijl en sfeer

RegPin heeft een fantasy- en roguelike-uitstraling geïnspireerd door Peglin: warme kleuren, houten materialen, runentekens, lichte gloed-effecten en subtiele magische geluiden. Elke hit geeft visuele feedback zoals particles of kleine vlammetjes.

## Structuur van het level

1. **Bovenaan**: De schietplek met de rune-ball launcher.
2. **Midden**: Een veld vol pegs, bumps en kristallen in een fantasypatroon.
3. **Onderaan**: Een opvangzone waar de bal landt om de beurt te beëindigen.

## Levelschets

```
       [ Launcher ]
          / | \
         v  v  v
      o   o   o   o
    o   *   o   *   o
      o   o   o   o
        *    o    *

  -----------------------
         opvangzone
```

## Inspiratie – Peglin

* Peglin combineert physics met RPG-achtige elementen, wat zorgt voor een speels maar strategisch gevoel.
* De bal voelt zwaar en realistisch, wat belangrijk is voor de satisfactie van het raken.
* De diagonale en ronde peg-layouts zorgen voor verrassende bounces.
* Elke hit geeft duidelijke feedback (particles, geluid, score pop-ups), wat erg motiverend werkt.

# Les 1A – Array en List: 

## Beschrijving
Je maakt een array van 10 strings waarin je verschillende items kunt opslaan. Door [SerializeField] te gebruiken wordt deze array zichtbaar in de Unity Inspector, zodat je hem handmatig kunt vullen met 10 item-namen.

## Demo
![Schermopname2025-11-20om12 31 13-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/fac5ff4b-2469-4b82-95d8-03baa0f32d27)



## Code
<img width="722" height="523" alt="Scherm­afbeelding 2025-11-20 om 12 30 51" src="https://github.com/user-attachments/assets/f426a3fc-b659-40f8-8a0a-1ff5ad3ac864" />

# Les 2.1  – Forces & Collision: 

## Beschrijving
In deze opdracht is een bal gemaakt die met AddForce wordt afgeschoten en reageert op Unity’s physics. De bal heeft een Rigidbody2D, een collider en een physics material zodat hij realistisch stuitert tegen muren, vloer en targets. Targets registreren botsingen met OnCollisionEnter2D, waardoor zichtbaar wordt wanneer de bal een object raakt. In de demo is te zien dat de bal wordt afgeschoten, botst tegen de omgeving en targets raakt.

## Demo
![Schermopname2025-12-15om14 04 12-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/2973bd0d-ff82-4777-b0b7-fa67375787de)

# Code
<img width="572" height="578" alt="Scherm­afbeelding 2025-12-15 om 14 20 10" src="https://github.com/user-attachments/assets/a3cda2e6-7820-4099-b878-d989268a44fc" />


# Les 2.2 – Peggle Game, Mikken, Schieten en Line Rendering: 

## Beschrijving
In dit Unity-project draait het kanon mee met de muis en kan het projectielen afschieten. Door de muisknop ingedrukt te houden bouw je kracht op; bij loslaten wordt de bal in de kijkrichting afgevuurd. Een line renderer laat tijdens het opladen zien hoe sterk het schot wordt.
## Demo
![Schermopname2025-12-15om14 04 12-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/53e4be0f-f8c8-4eec-9d62-440ac0702113)


## Code
<img width="617" height="349" alt="Scherm­afbeelding 2025-12-15 om 14 02 32" src="https://github.com/user-attachments/assets/f0201913-0acb-43ef-8b54-3dfc229fb81d" />
<img width="505" height="730" alt="Scherm­afbeelding 2025-12-15 om 14 03 18" src="https://github.com/user-attachments/assets/6397b904-3a5b-470c-8634-1662123701e7" />

# Les 3.1  – Score & Triggers: 

## Beschrijving
In deze opdracht is de basis van de Peggle-gameplay gemaakt. Een Peggle-object reageert wanneer het geraakt wordt door de bal, houdt bij hoeveel hits er nog over zijn en geeft per hit punten door aan de ScoreManager. Zodra het maximale aantal hits is bereikt, verdwijnt de Peggle automatisch uit de scene. Elke hit wordt visueel zichtbaar gemaakt, bijvoorbeeld door een kleurverandering. In de demo is te zien dat de Peggle geraakt wordt, de score oploopt en het object verdwijnt wanneer de hits op zijn.

## Demo
![Schermopname2025-12-15om14 04 12-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/2973bd0d-ff82-4777-b0b7-fa67375787de)

# Code
#<img width="585" height="512" alt="Scherm­afbeelding 2025-12-15 om 14 10 53" src="https://github.com/user-attachments/assets/b207639a-9295-429d-839b-c951d3692beb" />
<img width="488" height="539" alt="Scherm­afbeelding 2025-12-15 om 14 11 18" src="https://github.com/user-attachments/assets/cb517621-dc7e-4a7b-a3a0-db91b6722782" />

# Les 3.2  – Combo System en Bumpers: 

## Beschrijving
In deze opdracht is een combo-systeem gebouwd voor het Peggle-spel. Bumpers zijn verdeeld in verschillende types met eigen tags. Wanneer de bal meerdere bumpers met dezelfde tag achter elkaar raakt, wordt een combo opgebouwd en stijgt de score-multiplier. Bij het raken van een andere bumper wordt de combo gereset. De bumpers sturen via Action Events door wanneer ze geraakt worden. Het ComboSystem luistert naar deze events, controleert de volgorde van tags en berekent de score met een multiplier. De score wordt doorgegeven aan de ScoreManager. In de demo is te zien dat combo’s ontstaan, de multiplier oploopt en de score sneller stijgt.

## Demo
![Schermopname2025-12-15om14 04 12-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/2973bd0d-ff82-4777-b0b7-fa67375787de)

# Code
<img width="604" height="314" alt="Scherm­afbeelding 2025-12-15 om 14 15 43" src="https://github.com/user-attachments/assets/6a5f0187-1efd-4dc3-9575-9528f1e0eaf4" />
<img width="751" height="749" alt="Scherm­afbeelding 2025-12-15 om 14 16 03" src="https://github.com/user-attachments/assets/fe4ad39f-0a32-49be-bbe4-3a321b69f663" />
<img width="512" height="465" alt="Scherm­afbeelding 2025-12-15 om 14 15 10" src="https://github.com/user-attachments/assets/11b44563-65dc-4b0a-b1e3-1bf04b3b14b1" />


# Les 5.2 – Particles, Sound & Screenshake

## Beschrijving
In deze opdracht zijn particle effecten, geluid en screenshake toegevoegd aan het Peggle-spel om meer impact en feedback te geven wanneer de bal een bumper raakt.  
Elke bumper speelt een particle effect af bij een hit en er wordt een geluidseffect afgespeeld. Daarnaast trilt het scherm kort om de impact van de botsing te versterken.

De bumpers sturen via een `Action` event (`onHitBumper`) door wanneer ze geraakt worden. Dit event wordt gebruikt om meerdere systemen tegelijk aan te sturen, zoals particles, audio en screenshake. De screenshake wordt uitgevoerd met een coroutine, zodat de camera over meerdere frames vloeiend beweegt en daarna terugkeert naar zijn originele positie.

In de demo is te zien dat bij elke bumper-hit een explosie-effect verschijnt, een geluid wordt afgespeeld en het scherm kort schudt voor extra game feel.

## Demo


# Code

