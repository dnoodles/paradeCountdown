<template>
  <div class="card-examples row items-start">
    <q-card flat>
      <q-scroll-area style="height: 200px">
        <h5 :class="{'odd': x % 2 === 0, 'even': x % 2 !== 0 }" :key="x" v-for="(turn,x) in turns">{{ x + 1 + ': ' + turn }}</h5>
      </q-scroll-area>
    </q-card>
  </div>
</template>

<script>
import {
  QScrollArea,
  QCard,
  QCardTitle,
  QCardMedia,
  QCardActions,
  QCardSeparator,
  QCardMain,
  QList,
  QItem,
  QItemMain,
  QItemSide,
  QItemTile,
  QCollapsible,
  QRating,
  QBtn,
  QParallax,
  QIcon,
  QPopover,
  QVideo
} from 'quasar'
export default {
  components: {
    QScrollArea,
    QCard,
    QCardTitle,
    QCardMedia,
    QCardActions,
    QCardSeparator,
    QCardMain,
    QList,
    QItem,
    QItemMain,
    QItemSide,
    QItemTile,
    QCollapsible,
    QRating,
    QBtn,
    QParallax,
    QIcon,
    QPopover,
    QVideo
  },
  mounted () {
  },
  data () {
    return {
      turns: [
        'Right On Main Street',
        'Right On Singer Lane',
        'Left On Rte 111',
        'Left On Main Street',
        'Right On Redwood Lane STOP',
        'Left On Landing Avenue',
        'Right On Edgewood Avenue',
        'Right On Grill Drive',
        'Left On Borrell Court',
        'Left On Hartsdale Street',
        'Left On Grenrich Drive South',
        'Right On Edgewood Avenue',
        'Right On Rte 25A',
        'Right On Aron Street',
        'Left On Hurtin Blvd',
        'Right On Pia Blvd',
        'Left On Rte 25a',
        'Right On Howell Drive',
        'Left On Marquette Drive',
        'Right On Colgate Drive',
        'Right On hofstra Drive',
        'Left On East Hill Drive',
        'Right On Penn Drive',
        'Right On Baylor Drive',
        'Left On Howell Drive',
        'Right On Franklin Drive',
        'Right On Rte 25A',
        'Left On Terry Road',
        'Over Rte 347',
        'Right on Gilbert Drive',
        'Left On Ridgely Road',
        'Right On Steven Place',
        'Left On Cortland Row',
        'Right On Dorchester Road',
        'Right On Townline Road',
        'Right On Mt. Pleasant Road',
        'Right On Bow Drive',
        'Left On Rainbow Drive',
        'Left On Mount Pleasnt Road',
        'Left On Adreienne Lane',
        'Left On Sandra Drive',
        'Right On Stanley Place',
        'Left On Sheila Drive',
        'Right On Garvey Drive',
        'Right On S. Plaisted Avenue',
        'Left On Saturn Blvd',
        'Right On Sequoia Drive',
        'Right On Rte 347',
        'Right Into Meat Farms STOP',
        'Left On Mount Pleasant Road',
        'Left On Cross Street',
        'Left On Sterling Lane',
        'Left On Sherbrooke Drive',
        'Right On Rte 111',
        'Left On Maple Avenue',
        'Right On Lawrence Avenue',
        'Left On Elm Avenue',
        'Left On Main Street',
        'Left At Bull',
        'Right On Plymouth Blvd',
        'Left On Parnell Drive',
        'Right On Greenwich Road',
        'Left On Stuyvesant Lane',
        'Right On Morewood Drive',
        'Left On Charter Lane',
        'Left On Villa Lane',
        'Right On Stacey Lane',
        'Right On Leslie Lane',
        'Left On Villa Lane',
        'Right On Stanwich Road',
        'Left On Morewood Drive',
        'Left On Plymouth Blvd',
        'Right On Ridge Road',
        'Left On Hill Lane',
        'Left On Lindron Ave',
        'Right On Plymouth Blvd',
        'Right Into SHS West STOP',
        'Right On Plymouth Blvd',
        'Right On Old Northport Road',
        'Left On Alfred Lane',
        'Right On Melody Lane',
        'Right On Meadow Road',
        'Left On Poplar Drive',
        'Right On Hilltop Drive',
        'Left On Dillmont Drive',
        'Left On Meadow Road',
        'Left On Jericho Tpke',
        'Left On Rte 25',
        'Right On Summerset Drive',
        'Left On Everit Place',
        'Left On Eckernkamp Drive',
        'Right On N. Ingelore Court',
        'Right On River Heights Drive',
        'Left On Neil Drive',
        'Right On Oakside Drive',
        'Left On Burham Drive',
        'Left On Rose Street',
        'Left On St. Nicholas Avenue',
        'Left On Rte 25A',
        'Right On Derby Place',
        'Left On Sheryl Crescent',
        'Right On Winslow Lane',
        'Right On Hiawatha Lane',
        'Right On Derby Place',
        'Right On Rte 25A',
        'Right On Bishops Road',
        'Right On Rte 25A',
        'Left On Rte 25',
        'Right On Brooksite Drive',
        'Left On Mark Drive',
        'Left On Larkspur Drive',
        'Left On Cygnent Drive',
        'Right Brooksite Drive',
        'Left On Brook Lane',
        'Right On Crescent Place',
        'Left On Seaver Lane',
        'Right On Grassy Lane',
        'Right On Tanglewood Drive',
        'Right On Forest Lane East',
        'Over Brooksite',
        'Right On Merrivale Drive',
        'Left On Aberdeen Road',
        'Left On Merrivale Drive',
        'Right On Sunset Lane',
        'Left On Brooksite',
        'Right On Brook Lane',
        'Right On Maple Avenue',
        'Left On Rte 111',
        'Left On Main Street',
        'Right Onto Edgewood Ave',
        'Right Into Elks Lodge',
        'Right Onto Edgewood Ave',
        'Right On Langing Avenue',
        'Right On Main Street',
        'Left On Elm Avenue'
      ]
    }
  }
}
</script>
<style lang="stylus" scoped>
@import '~variables'
.even {
  color: $red-10;
  text-transform: uppercase;
  text-align: center;
}
.odd {
  color: $light-green-10;
  text-transform: uppercase;
  text-align: center;
}
.q-card
  width 30vw
@media (max-width $breakpoint-xs-max)
  .q-card
    width 100%
</style>