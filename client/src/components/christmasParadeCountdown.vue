<template>
  <div>
    <h1>Smithtown Fire Department</h1>
    <h2>Christmas Parade Countdown</h2>
    <!--<h3 id="countdown">{{weeks + (weeks === 1 ? ' Week ' : ' Weeks ')}}</h3>-->
    <h3 id="countdown">{{days + (weeks*7) + (days === 1 ? ' day ' : ' days ')}}</h3>
    <h3 id="countdown">{{hours +  (hours === 1 ? ' hour ' : ' hours ')}}</h3>
    <h3 id="countdown">{{minutes + (minutes === 1 ? ' minute ' : ' minutes ')}}</h3>
    <h3 id="countdown">{{seconds + (seconds === 1 ? ' second ' : ' seconds ')}}</h3>
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
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1 {
  color: #fc000096;
  text-transform: uppercase;
  text-align: center;
  font-size: 2.5rem;
  letter-spacing: .3rem;  
}
h2 {
  color: #fc000096;
  text-transform: uppercase;
  text-align: center;
  font-size: 2.0rem;
  letter-spacing: .3rem;
}

h3 {
  font-size: 1.4rem;
  letter-spacing: .3rem;
  color: #fc000096;
  text-transform: uppercase;
  text-align: center;
}
</style>
