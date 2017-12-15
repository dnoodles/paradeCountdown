<template>
  <div>
    <q-card flat>
      <q-card-title>
        <h2 class="even">Parade Countdown</h2>
      </q-card-title>
      <q-card-main>
        <div class="container row justify-between">
          <div class="col-6 even">
            <h3>{{daysCalc}}</h3>
            <h5>{{daysCalc === 1 ? ' day  ' : ' days '}}</h5>
          </div>
          <div class="col-6 even">
            <h3>{{hours}}</h3>
            <h5 >{{hours === 1 ? ' hour  ' : ' hours '}}</h5>
          </div>
          <div class="col-6 odd">
            <h3>{{minutes}}</h3>
            <h5>{{minutes === 1 ? ' minute  ' : ' minutes '}}</h5>
          </div>
          <div class="col-6 odd">
            <h3>{{seconds}}</h3>
            <h5>{{seconds === 1 ? ' second  ' : ' seconds '}}</h5>
          </div>
        </div>
      </q-card-main>
    </q-card>
  </div>
</template>

<script>
import {
  QCard,
  QCardTitle,
  QCardMain
} from 'quasar'
export default {
  components: {
    QCard,
    QCardTitle,
    QCardMain
  },
  name: 'christmasParadeCountdown',
  data () {
    return {
      paradeDate: new Date('2017-12-16T22:00:00.000Z'),
      weeks: null,
      days: null,
      hours: null,
      minutes: null,
      seconds: null
    }
  },
  mounted () {
    var targetDate = new Date(this.paradeDate)
    // find the amount of "seconds" between now and target
    var currentDate = new Date().getTime()
    var secondsLeft = (targetDate - currentDate) / 1000
    // do some time calculations
    this.days = parseInt(secondsLeft / 86400)
    secondsLeft = secondsLeft % 86400
    this.hours = parseInt(secondsLeft / 3600)
    secondsLeft = secondsLeft % 3600
    this.minutes = parseInt(secondsLeft / 60)
    this.seconds = parseInt(secondsLeft % 60)
    setInterval(() => {
      // find the amount of "seconds" between now and target
      var currentDate = new Date().getTime()
      var secondsLeft = (targetDate - currentDate) / 1000
      // do some time calculations
      this.weeks = parseInt(secondsLeft / 604800)
      secondsLeft = secondsLeft % 604800
      this.days = parseInt(secondsLeft / 86400)
      secondsLeft = secondsLeft % 86400
      this.hours = parseInt(secondsLeft / 3600)
      secondsLeft = secondsLeft % 3600
      this.minutes = parseInt(secondsLeft / 60)
      this.seconds = parseInt(secondsLeft % 60)
    }, 1000)
  },
  computed: {
    daysCalc () {
      return (this.weeks * 7) + this.days
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="stylus" scoped>
@import '~variables'
.even {
  color: $red-10;
  text-transform: uppercase;
  text-align: center;
}
.odd {
  color: $green-10;
  text-transform: uppercase;
  text-align: center;
}
</style>