<template>
  <div>
      <div class="container">
          <h1 class="title countdown_green">{{daysCalc}}</h1>
          <h1 class="subtitle countdown">{{daysCalc === 1 ? ' day  ' : ' days '}}</h1>
          <h1 class="title countdown_green">{{minutes}}</h1>
          <h1 class="subtitle countdown">{{minutes === 1 ? ' minute  ' : ' minutes '}}</h1>
          <h1 class="title countdown_green">{{hours}}</h1>
          <h1 class="subtitle countdown">{{hours === 1 ? ' hour  ' : ' hours '}}</h1>
          <h1 class="title countdown_green">{{seconds}}</h1>
          <h1 class="subtitle countdown">{{seconds === 1 ? ' second  ' : ' seconds '}}</h1>
      </div>
      <h1 class="title is-5">Christmas Parade Countdown</h1>
  </div>
</template>

<script>
export default {
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
<style scoped>
h5 {
  color: rgba(252, 0, 0, 0.5882352941176471);
  text-transform: uppercase;
  text-align: center;
}
h2 {
  color: rgba(4, 160, 4, 0.7803921568627451);
  text-transform: uppercase;
  text-align: center;
  font-size: 2.0rem;
  letter-spacing: .3rem;
}

h3 {
  margin: 0px;
}

.countdown {
  font-size: 1.4rem;
  letter-spacing: .3rem;
  color: rgba(252, 0, 0, 0.5882352941176471);
  text-transform: uppercase;
  text-align: center;
}
.countdown_green {
  font-size: 1.4rem;
  letter-spacing: .3rem;
  color: rgba(4, 160, 4, 0.7803921568627451);
  text-transform: uppercase;
  text-align: center;
}
</style>
