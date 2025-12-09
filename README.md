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

