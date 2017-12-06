<template>
  <div>
    <div id="countdownDiv">
      <h2>Christmas Parade Countdown</h2>
      <!--<h3 id="countdown">{{weeks + (weeks === 1 ? ' Week ' : ' Weeks ')}}</h3>-->
      <div class="container">
        <div class="child">
          <h3 class="countdown">{{days + (weeks*7)}}</h3>
          <h3 class="countdown bottomMargin">{{days === 1 ? ' day  ' : ' days '}}</h3>
          <h3 class="countdown_green">{{minutes}}</h3>
          <h3 class="countdown_green">{{minutes === 1 ? ' minute  ' : ' minutes '}}</h3>
        </div>
        <div class="child">
          <h3 class="countdown">{{hours}}</h3>
          <h3 class="countdown bottomMargin">{{hours === 1 ? ' hour  ' : ' hours '}}</h3>
          <h3 class="countdown_green">{{seconds}}</h3>
          <h3 class="countdown_green">{{seconds === 1 ? ' second  ' : ' seconds '}}</h3>
        </div>
      </div>
    </div>
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
.title {
  -ms-flex-item-align: start;
      align-self: flex-start;
}

h1 {
  color: rgba(252, 0, 0, 0.5882352941176471);
  text-transform: uppercase;
  text-align: center;
  font-size: 2.5rem;
  letter-spacing: .3rem;    
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

.container {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -ms-flex-line-pack: center;
    align-content: center;
}

.child {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: normal;
      -ms-flex-direction: column;
          flex-direction: column;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: center;
      -ms-flex-align: center;
          align-items: center;
  margin: auto;
}

.bottomMargin {
  margin-bottom: 25%
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
