<template>
  <q-layout
    ref="layout"
    view="hhh lpr fFf"
    :left-class="{'text-red-10': true}"
  >
    <q-toolbar slot="header" color="red-10" >
      <q-btn
        flat
        @click="$refs.layout.toggleLeft()"
      >
        <q-icon name="menu" />
      </q-btn>

      <q-toolbar-title>
        Christmas Parade
        <div slot="subtitle">Smithtown Fire Department</div>
      </q-toolbar-title>
    </q-toolbar>

    <div slot="left">
      <!--
        Use <q-side-link> component
        instead of <q-item> for
        internal vue-router navigation
      -->
      <q-list no-border link inset-delimiter dense>
        <q-list-header :class="{'text-red-10' : true}">
          SMITHTOWN FIRE DEPARTMENT
        </q-list-header>
        <q-side-link 
          item 
          :to="{name: 'countdown'}" 
          exact>        
          <q-item>
            <q-item-side icon="timer" />
            <q-item-main label="Countdown" sublabel="When can you watch?" />
          </q-item>
        </q-side-link>
        <q-side-link item :to="{name: 'santaTracker'}" exact>    
          <q-item>
            <q-item-side icon="track_changes" />
            <q-item-main label="Santa Tracker" sublabel="Follow Santa!" />
          </q-item>
        </q-side-link>
        <q-side-link item :to="{name: 'truckVote'}" exact disabled class="no-pointer-events">        
          <q-item>
            <q-item-side icon="favorite" />
            <q-item-main label="Vote" sublabel="Favorite Decorations?" />
          </q-item>
        </q-side-link>
        <q-side-link item :to="{name: 'checkIn'}" exact disabled class="no-pointer-events">
          <q-item>
            <q-item-side icon="check" />
            <q-item-main label="Check-In" sublabel="Where Are You Watching?" />
          </q-item>
        </q-side-link>
        <q-side-link item :to="{name: 'photos'}" exact disabled class="no-pointer-events">
          <q-item>
            <q-item-side icon="photo_camera" />
            <q-item-main label="Pictures" sublabel="Last years pictures, or upload your own!" />
          </q-item>
        </q-side-link>
      </q-list>
    </div>

    <!--
      Replace following <div> with
      <router-view /> component
      if using subRoutes
    -->
    <div class="layout-padding" id="snow">
      <router-view />
    </div>
  </q-layout>
</template>

<script>
import {
  QLayout,
  QToolbar,
  QToolbarTitle,
  QBtn,
  QIcon,
  QList,
  QListHeader,
  QItem,
  QItemSide,
  QSideLink,
  QItemMain
} from 'quasar'

export default {
  name: 'index',
  components: {
    QLayout,
    QToolbar,
    QToolbarTitle,
    QBtn,
    QIcon,
    QList,
    QListHeader,
    QItem,
    QItemSide,
    QSideLink,
    QItemMain
  },
  data () {
    return {
    }
  },
  computed: {
    userAgent () {
      return navigator.userAgent
    }
  },
  methods: {
  },
  mounted () {
  },
  beforeDestroy () {
  }
}
</script>
<style>
.unclickable {
  pointer-events: none
}

#snow{
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
      -ms-flex-flow: row wrap;
          flex-flow: row wrap;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: stretch;
      -ms-flex-align: stretch;
          align-items: stretch;
	height: 100%;
	position: absolute;
	width: 100%;
	z-index:1;
	background-color:rgba(0, 15, 47, 0.9490196078431372); 
	background-image: url('~assets//snow.png'), url('~assets//snow2.png'), url('~assets//snow3.png');
	-webkit-animation: snow 20s linear infinite;
	animation: snow 20s linear infinite;
}
@keyframes snow {
0% {background-position: 0px 0px, 0px 0px, 0px 0px;}
100% {background-position: 500px 1000px, 400px 400px, 300px 300px;}
}

@-webkit-keyframes snow {
0% {background-position: 0px 0px, 0px 0px, 0px 0px;}
100% {background-position: 500px 1000px, 400px 400px, 300px 300px;}
}

@-webkit-keyframes even-flash {
  0%, 100%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274);
            box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274)
  }
  50%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
            box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
  }
}

@keyframes even-flash {
  0%, 100%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274);
            box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274)
  }
  50%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
            box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
  }
}

@-webkit-keyframes odd-flash {
  50%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px #ff0000;
            box-shadow: 0 2px 20px 4px #ff0000; 
  }
  0%, 100%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
            box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
  }
}

@keyframes odd-flash {
  50%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px #ff0000;
            box-shadow: 0 2px 20px 4px #ff0000; 
  }
  0%, 100%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
            box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
  }
}
</style>