<template>
  <div>
    <h1 style="color: white">{{ 'Latitude: ' + lat + 'Longitude: ' + lon}}</h1>
    <h3 style="color: white">{{test}}</h3>
  </div>
</template>

<script>
export default {
  name: 'christmasParadeCountdown',
  data () {
    return {
      lat: null,
      lon: null,
      test: 0
    }
  },
  methods: {
  },
  mounted () {
    setInterval(() => {
      console.log('test')
      this.test++
      navigator.geolocation.getCurrentPosition((position) => {
        this.lat = position.coords.latitude
        this.lon = position.coords.longitude
      })
    }, 5000)
  },
  computed: {
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
  margin-left: 3%;
  margin-right: 3%;
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
