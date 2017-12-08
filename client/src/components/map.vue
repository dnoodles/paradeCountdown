<template>
  <div>
    <div class="container">
      <div class="child">
        <h3 style="color: white">Pinch to Zoom</h3>
        <canvas id="mycanvas"></canvas>
      </div>
    </div>
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
      zoomMax: 1,
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
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#mycanvas {
  height: 200px;
  width: 400px
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
}
</style>
