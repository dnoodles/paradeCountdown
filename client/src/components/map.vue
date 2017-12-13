<template>
  <div class="child">
    <canvas id="mycanvas"></canvas>
    <h3 style="color: white" v-if="(/Android|webOS|iPhone|iPad|iPod|BlackBerry|BB|PlayBook|IEMobile|Windows Phone|Kindle|Silk|Opera Mini/i.test(userAgent))">Pinch to Zoom</h3>
    <h3 style="color: white" v-else>Click to Zoom</h3>    
  </div>
</template>

<script>
import map from '../assets/christmasParadeMap.jpg'
import PinchZoomCanvas from 'pinch-Zoom-Canvas'

export default {
  name: 'map',
  data () {
    return {
      noCanvas: true
    }
  },
  mounted () {
    var pinchZoom = new PinchZoomCanvas({
      canvas: document.getElementById('mycanvas'),

      path: map,
      momentum: true,
      zoomMax: 6,
      doubletap: true,
      onZoomEnd: function (zoom, zoomed) {
        console.log('---> is zoomed: %s', zoomed)
        console.log('---> zoom end at %s', zoom)
      },
      onZoom: function (zoom) {
        console.log('---> zoom is %s', zoom)
      }
    })
    console.log(pinchZoom)
  },
  methods: {
  },
  computed: {
    userAgent () {
      return navigator.userAgent
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#mycanvas {
  height: 300px;
  width: 600px
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
}
@media screen and (min-width: 500px) {
  canvas {
      transition: -webkit-transform .5s ease;
  }

  canvas:active {
      -webkit-transform: scale(5);
  }
}
</style>
